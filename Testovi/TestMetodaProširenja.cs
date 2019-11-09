using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Vsite.CSharp.KontrolaToka.Testovi
{
    [TestClass]
    public class TestMetodaProširenja
    {
        [TestMethod]
        public void SadržiVraćaTrueZaRiječKojaJeUNizu()
        {
            string[] riječi = new string[] { "Franjo", "Ivana", "Dora", "Mirko" };
            Assert.IsTrue(Pretraga.Sadrži(riječi, "Dora"));
        }

        [TestMethod]
        public void SadržiVraćaFalseZaRiječKojaNijeUNizu()
        {
            string[] riječi = new string[] { "Franjo", "Ivana", "Dora", "Mirko" };
            Assert.IsFalse(Pretraga.Sadrži(riječi, "Ema"));
        }

        [TestMethod]
        public void ZbrojiVraćaIspravanZbrojZaNizCijelihBrojeva()
        {
            int[] brojevi = new int[] { 1, 2, 4, 5, 12, 13 };
            Assert.AreEqual(37, Pretraga.Zbroj(brojevi));
        }

        [TestMethod]
        public void VraćaSveRiječiKojeSuPoAbecediIzaZadane()
        {
            string[] riječi = new string[] { "auto", "more", "sunce", "mama", "stolica", "kukuruz" };
            var rez = Pretraga.NađiSveIza(riječi, "punica");
            Assert.AreEqual(2, rez.Count());
            Assert.IsTrue(rez.Contains("sunce"));
            Assert.IsTrue(rez.Contains("stolica"));
        }
    }
}
