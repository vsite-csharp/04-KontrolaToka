using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.KontrolaToka.Testovi
{
    [TestClass]
    public class TestNaredbeBreakContinue
    {
        [TestMethod]
        public void NaredbeBreakContinue_ZbrojiDoNSveKojiSuDjeljiviSaD()
        {
            Assert.AreEqual(30, NaredbeBreakContinue.ZbrojiDoNSveKojiSuDjeljiviSaD(10, 2));
            Assert.AreEqual(18, NaredbeBreakContinue.ZbrojiDoNSveKojiSuDjeljiviSaD(10, 3));
            Assert.AreEqual(12, NaredbeBreakContinue.ZbrojiDoNSveKojiSuDjeljiviSaD(10, 4));
        }

        [TestMethod]
        public void NaredbeBreakContinue_ZbrojiDoNSveKojiSuDjeljiviSaDAliSamoDoPrvogDjeljivogSaD2()
        {
            Assert.AreEqual(2, NaredbeBreakContinue.ZbrojiDoNSveKojiSuDjeljiviSaDAliSamoDoPrvogDjeljivogSaD2(10, 2, 4));
            Assert.AreEqual(18, NaredbeBreakContinue.ZbrojiDoNSveKojiSuDjeljiviSaDAliSamoDoPrvogDjeljivogSaD2(10, 3, 8));
            Assert.AreEqual(4, NaredbeBreakContinue.ZbrojiDoNSveKojiSuDjeljiviSaDAliSamoDoPrvogDjeljivogSaD2(10, 4, 8));
        }
    }
}
