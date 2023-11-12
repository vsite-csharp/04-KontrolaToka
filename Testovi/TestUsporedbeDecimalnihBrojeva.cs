namespace Vsite.CSharp.KontrolaToka.Testovi
{
    [TestClass]
    public class TestUsporedbeDecimalnihBrojeva
    {
        [TestMethod]
        public void UsporedbaDvijeTrećine()
        {
            double tri = 3.0;
            Assert.IsTrue(UsporedbeDecimalnihBrojeva.JednakiSu((1.0 - 1.0 / tri), (2.0 / tri)));
            Assert.IsFalse(UsporedbeDecimalnihBrojeva.JednakiSu(0.66667, (1.0 - 1.0 / tri)));
            Assert.IsFalse(UsporedbeDecimalnihBrojeva.JednakiSu(0.66667, (2.0 / tri)));
            Assert.IsFalse(UsporedbeDecimalnihBrojeva.JednakiSu(1e15, (2.0 / tri)));
            Assert.IsFalse(UsporedbeDecimalnihBrojeva.JednakiSu(-1e15, (2.0 / tri)));
            Assert.IsFalse(UsporedbeDecimalnihBrojeva.JednakiSu(1e-15, (2.0 / tri)));
            Assert.IsFalse(UsporedbeDecimalnihBrojeva.JednakiSu(-1e-15, (2.0 / tri)));
        }

        [TestMethod]
        public void UsporedbaTriDesetine()
        {
            double tri = 3.0;
            Assert.IsTrue(UsporedbeDecimalnihBrojeva.JednakiSu(tri * 0.1, 0.3));
            Assert.IsFalse(UsporedbeDecimalnihBrojeva.JednakiSu(0.30001, tri * 0.1));
            Assert.IsFalse(UsporedbeDecimalnihBrojeva.JednakiSu(0.30001, 0.3));
            Assert.IsFalse(UsporedbeDecimalnihBrojeva.JednakiSu(1e15, 0.3));
            Assert.IsFalse(UsporedbeDecimalnihBrojeva.JednakiSu(-1e15, 0.3));
            Assert.IsFalse(UsporedbeDecimalnihBrojeva.JednakiSu(1e-15, 0.3));
            Assert.IsFalse(UsporedbeDecimalnihBrojeva.JednakiSu(-1e-15, 0.3));
        }

        [TestMethod]
        public void UsporedbaDvaVrloMalaBroja()
        {
            Assert.IsFalse(UsporedbeDecimalnihBrojeva.JednakiSu(-1e-34, -1.00001e-34));
            Assert.IsFalse(UsporedbeDecimalnihBrojeva.JednakiSu(1e-34, 1.00001e-34));
            Assert.IsFalse(UsporedbeDecimalnihBrojeva.JednakiSu(1e-34, -1e-34));
            Assert.IsTrue(UsporedbeDecimalnihBrojeva.JednakiSu(-1e-34, -1e-34));
            Assert.IsTrue(UsporedbeDecimalnihBrojeva.JednakiSu(1e-34, 1e-34));
        }
        [TestMethod]
        public void UsporedbaDvaVrloVelikaBroja()
        {
            Assert.IsFalse(UsporedbeDecimalnihBrojeva.JednakiSu(-1e40, -1.00001e40));
            Assert.IsFalse(UsporedbeDecimalnihBrojeva.JednakiSu(1e40, 1.00001e40));
            Assert.IsFalse(UsporedbeDecimalnihBrojeva.JednakiSu(1e40, -1e40));
            Assert.IsTrue(UsporedbeDecimalnihBrojeva.JednakiSu(-1e40, -1e40));
            Assert.IsTrue(UsporedbeDecimalnihBrojeva.JednakiSu(1e40, 1e40));
        }
    }
}
