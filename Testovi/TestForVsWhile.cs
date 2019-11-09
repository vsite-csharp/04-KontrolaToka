using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.KontrolaToka.Testovi
{
    [TestClass]
    public class TestForVsWhile : ConsoleTest
    {
        [TestMethod]
        public void PetljaFor()
        {
            ForVsWhile.PetljaFor(5);
            Assert.AreEqual(0, cw.GetInt());
            Assert.AreEqual(1, cw.GetInt());
            Assert.AreEqual(2, cw.GetInt());
            Assert.AreEqual(3, cw.GetInt());
            Assert.AreEqual(4, cw.GetInt());
            Assert.AreEqual(5, cw.GetInt());
            Assert.IsTrue(cw.IsEmpty);
        }

        [TestMethod]
        public void PetljaWhile()
        {
            ForVsWhile.PetljaWhile(5);
            Assert.AreEqual(0, cw.GetInt());
            Assert.AreEqual(1, cw.GetInt());
            Assert.AreEqual(2, cw.GetInt());
            Assert.AreEqual(3, cw.GetInt());
            Assert.AreEqual(4, cw.GetInt());
            Assert.AreEqual(5, cw.GetInt());
            Assert.IsTrue(cw.IsEmpty);
        }
    }
}
