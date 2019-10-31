using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Vsite.CSharp.KontrolaToka.Testovi
{
    [TestClass]
    public class TestYield
    {
        [TestMethod]
        public void Yield_MetodaFibonacciVraćaNiz()
        {
            var niz = Yield.FibonacciIEnumerable();
            // provjera da rezultat nije neka kolekcija
            Assert.IsTrue(niz.GetType().GetProperty("Count") == null && niz.GetType().GetProperty("Length") == null);
            Assert.AreEqual(0, niz.ElementAt(0));
            Assert.AreEqual(1, niz.ElementAt(1));
            Assert.AreEqual(8, niz.ElementAt(6));
        }
    }
}
