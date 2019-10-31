using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Vsite.CSharp.KontrolaToka.Testovi
{
    [TestClass]
    public class TestGrananjaSwitch
    {
        [TestMethod]
        public void ImeDanaUTjednuVraćaPonedjeljak()
        {
            Assert.AreEqual("ponedjeljak", IspisDana.ImeDana(DayOfWeek.Monday), true);
        }

        [TestMethod]
        public void ImeDanaUTjednuVraćaUtorak()
        {
            Assert.AreEqual("utorak", IspisDana.ImeDana(DayOfWeek.Tuesday), true);
        }

        [TestMethod]
        public void ImeDanaUTjednuVraćaSrijeda()
        {
            Assert.AreEqual("srijeda", IspisDana.ImeDana(DayOfWeek.Wednesday), true);
        }

        [TestMethod]
        public void ImeDanaUTjednuVraćaČetvrtak()
        {
            Assert.AreEqual("četvrtak", IspisDana.ImeDana(DayOfWeek.Thursday), true);
        }

        [TestMethod]
        public void ImeDanaUTjednuVraćaPetak()
        {
            Assert.AreEqual("petak", IspisDana.ImeDana(DayOfWeek.Friday), true);
        }

        [TestMethod]
        public void ImeDanaUTjednuVraćaSubota()
        {
            Assert.AreEqual("subota", IspisDana.ImeDana(DayOfWeek.Saturday), true);
        }

        [TestMethod]
        public void ImeDanaUTjednuVraćaNedjelja()
        {
            Assert.AreEqual("nedjelja", IspisDana.ImeDana(DayOfWeek.Sunday), true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ImeDanaUTjednuBacaIznimkuZaNepoznatiDan()
        {
            IspisDana.ImeDana((DayOfWeek)10);
        }

        [TestMethod]
        public void RadniNeradniVraćaRadniDanZaPonedjeljak()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Monday), true);
        }

        [TestMethod]
        public void RadniNeradniVraćaRadniDanZaUtorak()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Tuesday), true);
        }

        [TestMethod]
        public void RadniNeradniVraćaRadniDanZaSrijedu()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Wednesday), true);
        }

        [TestMethod]
        public void RadniNeradniVraćaRadniDanZaČetvrtak()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Thursday), true);
        }

        [TestMethod]
        public void RadniNeradniVraćaRadniDanZaPetak()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Friday), true);
        }

        [TestMethod]
        public void RadniNeradniVraćaVikendZaSubotu()
        {
            Assert.AreEqual("vikend", IspisDana.RadniNeradni(DayOfWeek.Saturday), true);
        }

        [TestMethod]
        public void RadniNeradniVraćaVikendZaNedjelju()
        {
            Assert.AreEqual("vikend", IspisDana.RadniNeradni(DayOfWeek.Sunday), true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RadniNeradniBacaIznimkuZaNepoznatiDan()
        {
            IspisDana.ImeDana((DayOfWeek)10);
        }
    }
}
