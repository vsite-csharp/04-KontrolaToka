using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.KontrolaToka.Testovi
{
    [TestClass]
    public class TestNulStapajućegOperatora : ConsoleTest
    {
        [TestMethod]
        public void NulStapajućiOperator_IspišiStringIspisujeZadaniTekst()
        {
            string ime = "Pero";
            NulStapajućiOperator.IspišiString(ime);
            Assert.AreEqual("Pero", cw.GetString());
        }

        [TestMethod]
        public void NulStapajućiOperator_IspišiStringZaNulStringIspisujeNedefiniran()
        {
            string ime = null;
            NulStapajućiOperator.IspišiString(ime);
            Assert.AreEqual("Nedefiniran", cw.GetString());
        }

        [TestMethod]
        public void NulStapajućiOperator_IspišiStringZaZadaniCijeliBrojIspisujeNjegovuVrijednost()
        {
            int broj = 54;
            NulStapajućiOperator.IspišiString(broj);
            Assert.AreEqual("54", cw.GetString());
        }

        [TestMethod]
        public void NulStapajućiOperator_IspišiStringZaNulBrojIspisujeNedefiniran()
        {
            double? broj = null;
            NulStapajućiOperator.IspišiString(broj);
            Assert.AreEqual("Nedefiniran", cw.GetString());
        }
    }
}
