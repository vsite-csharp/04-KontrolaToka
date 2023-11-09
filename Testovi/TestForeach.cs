﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace Vsite.CSharp.KontrolaToka.Testovi
{
    [TestClass]
    public class TestForeach : ConsoleTest
    {
        [TestMethod]
        public void IspišiZaNizStringova()
        {
            Foreach.Ispiši(new string[] { "Ivo", "Tomislav", "Andrej" });
            Assert.AreEqual("Ivo", cw?.GetString());
            Assert.AreEqual("Tomislav", cw?.GetString());
            Assert.AreEqual("Andrej", cw?.GetString());
        }

        [TestMethod]
        public void IspišiZaQueue()
        {
            Foreach.Ispiši(new Queue(new string[] { "Ivo", "Tomislav", "Andrej" }));
            Assert.AreEqual("Ivo", cw?.GetString());
            Assert.AreEqual("Tomislav", cw?.GetString());
            Assert.AreEqual("Andrej", cw?.GetString());
        }
    }
}
