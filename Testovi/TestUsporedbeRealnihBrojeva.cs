using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.KontrolaToka.Testovi
{
    [TestClass]
    public class TestUsporedbeRealnihBrojeva
    {
        [TestMethod]
        public void UsporedbeRealnihBrojeva_UsporedbaDvijeTrećine()
        {
            double tri = 3.0;
            Assert.IsTrue(UsporedbeRealnihBrojeva.JednakiSu((1.0 - 1.0 / tri), (2.0 / tri)));
            Assert.IsFalse(UsporedbeRealnihBrojeva.JednakiSu(0.66667, (1.0 - 1.0 / tri)));
            Assert.IsFalse(UsporedbeRealnihBrojeva.JednakiSu(0.66667, (2.0 / tri)));
            Assert.IsFalse(UsporedbeRealnihBrojeva.JednakiSu(1e15, (2.0 / tri)));
            Assert.IsFalse(UsporedbeRealnihBrojeva.JednakiSu(-1e15, (2.0 / tri)));
            Assert.IsFalse(UsporedbeRealnihBrojeva.JednakiSu(1e-15, (2.0 / tri)));
            Assert.IsFalse(UsporedbeRealnihBrojeva.JednakiSu(-1e-15, (2.0 / tri)));
        }

        [TestMethod]
        public void UsporedbeRealnihBrojeva_UsporedbaTriDesetine()
        {
            double tri = 3.0;
            Assert.IsTrue(UsporedbeRealnihBrojeva.JednakiSu(tri * 0.1, 0.3));
            Assert.IsFalse(UsporedbeRealnihBrojeva.JednakiSu(0.30001, tri * 0.1));
            Assert.IsFalse(UsporedbeRealnihBrojeva.JednakiSu(0.30001, 0.3));
            Assert.IsFalse(UsporedbeRealnihBrojeva.JednakiSu(1e15, 0.3));
            Assert.IsFalse(UsporedbeRealnihBrojeva.JednakiSu(-1e15, 0.3));
            Assert.IsFalse(UsporedbeRealnihBrojeva.JednakiSu(1e-15, 0.3));
            Assert.IsFalse(UsporedbeRealnihBrojeva.JednakiSu(-1e-15, 0.3));
        }
    }
}
