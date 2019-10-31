using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.KontrolaToka.Testovi
{
    [TestClass]
    public class TestNulUvjetnogOperatora
    {
        [TestMethod]
        public void NulUvjetniOperator_PozoviToStringVraćaNulreferencuZaNulObjekt()
        {
            Assert.AreEqual(null, NulUvjetniOperator.PozoviToString(null));
        }

        [TestMethod]
        public void NulUvjetniOperator_PozoviToStringVraćaTekstZaString()
        {
            Assert.AreEqual("Mario", NulUvjetniOperator.PozoviToString("Mario"));
        }

        [TestMethod]
        public void NulUvjetniOperator_PozoviToStringVraćaPunoImeTipaZaObject()
        {
            Assert.AreEqual("System.Object", NulUvjetniOperator.PozoviToString(new object()));
        }
    }
}
