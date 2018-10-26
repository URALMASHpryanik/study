using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SandBox777;

namespace LogAnUnitTests
{
    [TestFixture]
    class LogAnalyzerTests
    {
        [Test]
        public void IsValidLogFileName_BadExtension_ReturnFalse()
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName("azaza.txt");

            Assert.False(result);
        }

        [TestCase("azaza.SLF")]
        [TestCase("azaza.slf")]
        public void IsValidLogFileName_ValidExtension_ReturnsTrue(string file)
        {
            LogAnalyzer analyzer = new LogAnalyzer();

            bool result = analyzer.IsValidLogFileName(file);

            Assert.True(result);
        }
    }
}
