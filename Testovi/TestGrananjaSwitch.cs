using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Vsite.CSharp.KontrolaToka.Testovi
{
    [TestClass]
    public class TestGrananjaSwitch
    {
        [TestMethod]
        public void GrananjeSwitch_ImeDanaUTjednuVraćaPonedjeljak()
        {
            Assert.AreEqual("ponedjeljak", IspisDana.ImeDana(DayOfWeek.Monday), true);
        }

        [TestMethod]
        public void GrananjeSwitch_ImeDanaUTjednuVraćaUtorak()
        {
            Assert.AreEqual("utorak", IspisDana.ImeDana(DayOfWeek.Tuesday), true);
        }

        [TestMethod]
        public void GrananjeSwitch_ImeDanaUTjednuVraćaSrijeda()
        {
            Assert.AreEqual("srijeda", IspisDana.ImeDana(DayOfWeek.Wednesday), true);
        }

        [TestMethod]
        public void GrananjeSwitch_ImeDanaUTjednuVraćaČetvrtak()
        {
            Assert.AreEqual("četvrtak", IspisDana.ImeDana(DayOfWeek.Thursday), true);
        }

        [TestMethod]
        public void GrananjeSwitch_ImeDanaUTjednuVraćaPetak()
        {
            Assert.AreEqual("petak", IspisDana.ImeDana(DayOfWeek.Friday), true);
        }

        [TestMethod]
        public void GrananjeSwitch_ImeDanaUTjednuVraćaSubota()
        {
            Assert.AreEqual("subota", IspisDana.ImeDana(DayOfWeek.Saturday), true);
        }

        [TestMethod]
        public void GrananjeSwitch_ImeDanaUTjednuVraćaNedjelja()
        {
            Assert.AreEqual("nedjelja", IspisDana.ImeDana(DayOfWeek.Sunday), true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GrananjeSwitch_ImeDanaUTjednuBacaIznimkuZaNepoznatiDan()
        {
            IspisDana.ImeDana((DayOfWeek)10);
        }

        [TestMethod]
        public void GrananjeSwitch_RadniNeradniVraćaRadniDanZaPonedjeljak()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Monday), true);
        }

        [TestMethod]
        public void GrananjeSwitch_RadniNeradniVraćaRadniDanZaUtorak()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Tuesday), true);
        }

        [TestMethod]
        public void GrananjeSwitch_RadniNeradniVraćaRadniDanZaSrijedu()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Wednesday), true);
        }

        [TestMethod]
        public void GrananjeSwitch_RadniNeradniVraćaRadniDanZaČetvrtak()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Thursday), true);
        }

        [TestMethod]
        public void GrananjeSwitch_RadniNeradniVraćaRadniDanZaPetak()
        {
            Assert.AreEqual("radni dan", IspisDana.RadniNeradni(DayOfWeek.Friday), true);
        }

        [TestMethod]
        public void GrananjeSwitch_RadniNeradniVraćaVikendZaSubotu()
        {
            Assert.AreEqual("vikend", IspisDana.RadniNeradni(DayOfWeek.Saturday), true);
        }

        [TestMethod]
        public void GrananjeSwitch_RadniNeradniVraćaVikendZaNedjelju()
        {
            Assert.AreEqual("vikend", IspisDana.RadniNeradni(DayOfWeek.Sunday), true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GrananjeSwitch_RadniNeradniBacaIznimkuZaNepoznatiDan()
        {
            IspisDana.ImeDana((DayOfWeek)10);
        }
    }
}
