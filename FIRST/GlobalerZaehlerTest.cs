using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FIRST
{
    [TestClass]
    public class GlobalerZaehlerTest
    {
        [TestMethod]
        public void KannErhoehtWerden()
        {
            GlobalerZaehler.Erhoehe();
            Assert.AreEqual(1, GlobalerZaehler.Stand());
        }

        [TestMethod]
        public void KannMehrfachErhoehtWerden()
        {
            GlobalerZaehler.Erhoehe();
            Assert.AreEqual(2, GlobalerZaehler.Stand());
        }
    }

    public class GlobalerZaehler
    {
        private static int _stand;

        public static void Erhoehe()
        {
            _stand++;
        }

        public static int Stand()
        {
            return _stand;
        }
    }
}
