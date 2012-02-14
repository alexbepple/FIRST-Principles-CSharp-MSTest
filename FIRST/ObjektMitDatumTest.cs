using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FIRST
{
    [TestClass]
    public class ObjektMitDatumTest
    {
        private ObjektMitDatum _objektMitDatum = new ObjektMitDatum();

        [TestMethod]
        public void MerktSichWannEsErstelltWurde()
        {
            Assert.AreEqual(DateTime.Now, _objektMitDatum.ErstellungsDatum);
        }

        [TestMethod]
        public void MerktSichWannEsErstelltWurde2()
        {
            Console.WriteLine(_objektMitDatum.ErstellungsDatum);
        }
    }

    public class ObjektMitDatum
    {
        private DateTime _erstellungsDatum;

        public ObjektMitDatum()
        {
            _erstellungsDatum = DateTime.Now;
        }

        public DateTime ErstellungsDatum
        {
            get { return _erstellungsDatum; }
        }
    }
}
