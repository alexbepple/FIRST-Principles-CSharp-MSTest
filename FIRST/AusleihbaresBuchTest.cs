using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FIRST
{
    [TestClass]
    public class AusleihbaresBuchTest
    {
        [TestMethod]
        public void KannAusgeliehenUndZurueckGegebenWerden()
        {
            var buch = new AusleihbaresBuch();
            buch.LeiheAus();
            Assert.IsFalse(buch.IstAusleihbar());
            buch.GibZurueck();
            Assert.IsTrue(buch.IstAusleihbar());
        }
    }

    public class AusleihbaresBuch
    {
        private bool _istAusleihbar = true;

        public void LeiheAus()
        {
            _istAusleihbar = false;
        }

        public bool IstAusleihbar()
        {
            return _istAusleihbar;
        }

        public void GibZurueck()
        {
            _istAusleihbar = true;
        }
    }
}
