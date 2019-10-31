using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.KontrolaToka.Testovi
{
    [TestClass]
    public class TestUvjetnogPridruživanja : ConsoleTest
    {
        [TestMethod]
        public void UvjetnoPridruživanje_IspišiParnostUvjetnimPridruživanjem()
        {
            IspišiParnost.UvjetnimPridruživanjem(1);
            Assert.AreEqual("Broj 1 je neparan", cw.GetString(), true);
            IspišiParnost.UvjetnimPridruživanjem(2);
            Assert.AreEqual("Broj 2 je paran", cw.GetString(), true);
            IspišiParnost.UvjetnimPridruživanjem(3);
            Assert.AreEqual("Broj 3 je neparan", cw.GetString(), true);
            IspišiParnost.UvjetnimPridruživanjem(4);
            Assert.AreEqual("Broj 4 je paran", cw.GetString(), true);
        }

        [TestMethod]
        public void UvjetnoPridruživanje_IspišiParnostGrananjemIf()
        {
            IspišiParnost.GrananjemIf(1);
            Assert.AreEqual("Broj 1 je neparan", cw.GetString(), true);
            IspišiParnost.GrananjemIf(2);
            Assert.AreEqual("Broj 2 je paran", cw.GetString(), true);
            IspišiParnost.GrananjemIf(3);
            Assert.AreEqual("Broj 3 je neparan", cw.GetString(), true);
            IspišiParnost.GrananjemIf(4);
            Assert.AreEqual("Broj 4 je paran", cw.GetString(), true);
        }
    }
}
