﻿namespace Vsite.CSharp.KontrolaToka.Testovi
{
    [TestClass]
    public class TestGrananjaIf : ConsoleTest
    {
        [TestMethod]
        public void ZaBrojDjeljivS_2()
        {
            GranjanjeIf.ProvjeriDjeljivost(2);
            Assert.AreEqual("broj je djeljiv s 2", cw?.GetString());
            GranjanjeIf.ProvjeriDjeljivost(4);
            Assert.AreEqual("broj je djeljiv s 2", cw?.GetString());
            GranjanjeIf.ProvjeriDjeljivost(6);
            Assert.AreEqual("broj je djeljiv s 2", cw?.GetString());
        }

        [TestMethod]
        public void ZaBrojDjeljivS_3()
        {
            GranjanjeIf.ProvjeriDjeljivost(3);
            Assert.AreEqual("broj je djeljiv s 3", cw?.GetString());
            GranjanjeIf.ProvjeriDjeljivost(6);
            Assert.AreEqual("broj je djeljiv s 2", cw?.GetString());
            GranjanjeIf.ProvjeriDjeljivost(9);
            Assert.AreEqual("broj je djeljiv s 3", cw?.GetString());
        }

        [TestMethod]
        public void ZaBrojDjeljivS_5()
        {
            GranjanjeIf.ProvjeriDjeljivost(5);
            Assert.AreEqual("broj je djeljiv s 5", cw?.GetString());
            GranjanjeIf.ProvjeriDjeljivost(10);
            Assert.AreEqual("broj je djeljiv s 2", cw?.GetString());
            GranjanjeIf.ProvjeriDjeljivost(15);
            Assert.AreEqual("broj je djeljiv s 3", cw?.GetString());
        }

        [TestMethod]
        public void ZaBrojKojiNijeDjeljivS_2_3_5()
        {
            GranjanjeIf.ProvjeriDjeljivost(1);
            Assert.AreEqual("broj nije djeljiv s 2, 3 niti 5", cw?.GetString());
            GranjanjeIf.ProvjeriDjeljivost(7);
            Assert.AreEqual("broj nije djeljiv s 2, 3 niti 5", cw?.GetString());
            GranjanjeIf.ProvjeriDjeljivost(11);
            Assert.AreEqual("broj nije djeljiv s 2, 3 niti 5", cw?.GetString());
        }
    }
}
