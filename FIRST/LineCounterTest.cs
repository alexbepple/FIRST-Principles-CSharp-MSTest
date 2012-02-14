using System.IO;
using System.Net;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FIRST
{
    [TestClass]
    public class LineCounterTest
    {
        [TestMethod]
        public void CountsLines()
        {
            var webClient = new WebClient();
            var fileName = @"rss.xml";
            webClient.DownloadFile("http://agileinaflash.blogspot.com/feeds/posts/default", fileName);

            var lineCounter = new LineCounter(@"rss.xml");
            Assert.AreEqual(1, lineCounter.NumberOfLines());
        }
    }

    public class LineCounter
    {
        private string[] _lines;

        public LineCounter(string fileName)
        {
            _lines = File.ReadAllLines(fileName);
        }

        public int NumberOfLines()
        {
            return _lines.Count();
        }
    }
}
