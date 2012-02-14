using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FIRST
{
    [TestClass]
    public class WortlaengenHistogrammTest
    {
        [TestMethod]
        public void GruppiertWoerterNachIhrerLaenge()
        {
            var histogramm = ErstelleHistogramm("foo foobar");
            Assert.IsTrue(histogramm[3].Contains("foo"));
            Assert.IsTrue(histogramm[6].Contains("foobar"));
        }

        private Dictionary<int, List<string>> ErstelleHistogramm(string woerter)
        {
            return null;
        }
    }
}
