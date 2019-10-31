namespace Vsite.CSharp.KontrolaToka.Testovi
{
    [TestClass]
    public class TestNulUvjetnogOperatora
    {
        [TestMethod]
        public void PozoviToStringVraćaNulreferencuZaNulObjekt()
        {
            Assert.AreEqual(null, NulUvjetniOperator.PozoviToString(null));
        }

        [TestMethod]
        public void PozoviToStringVraćaTekstZaString()
        {
            Assert.AreEqual("Mario", NulUvjetniOperator.PozoviToString("Mario"));
        }

        [TestMethod]
        public void PozoviToStringVraćaPunoImeTipaZaObject()
        {
            Assert.AreEqual("System.Object", NulUvjetniOperator.PozoviToString(new object()));
        }
    }
}
