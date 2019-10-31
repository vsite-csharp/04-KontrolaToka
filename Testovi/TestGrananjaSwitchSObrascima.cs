namespace Vsite.CSharp.KontrolaToka.Testovi
{
    [TestClass]
    public class TestGrananjaSwitchSObrascima : ConsoleTest
    {

        readonly Student student = new Student("Pero", 1);

        [TestMethod]
        public void StudentJeBrucoš()
        {
            GrananjeSwitchSObrascima.IspišiStudenta(student);
            Assert.AreEqual("Pero je brucoš", cw?.GetString());
        }

        [TestMethod]
        public void StudentDrugeGodinePreddiplomskogStudija()
        {
            student.PoložiGodinu();
            GrananjeSwitchSObrascima.IspišiStudenta(student);
            Assert.AreEqual("Pero je student 2. godine prediplomskog studija", cw?.GetString());
        }

        [TestMethod]
        public void StudentTrećeGodinePreddiplomskogStudija()
        {
            student.PoložiGodinu();
            student.PoložiGodinu();
            GrananjeSwitchSObrascima.IspišiStudenta(student);
            Assert.AreEqual("Pero je student 3. godine prediplomskog studija", cw?.GetString());
        }

        [TestMethod]
        public void StudentPrveGodineDiplomskogStudija()
        {
            student.PoložiGodinu();
            student.PoložiGodinu();
            student.PoložiGodinu();
            GrananjeSwitchSObrascima.IspišiStudenta(student);
            Assert.AreEqual("Pero je student 1. godine diplomskog studija", cw?.GetString());
        }

        [TestMethod]
        public void StudentDrugeGodineDiplomskogStudija()
        {
            student.PoložiGodinu();
            student.PoložiGodinu();
            student.PoložiGodinu();
            student.PoložiGodinu();
            GrananjeSwitchSObrascima.IspišiStudenta(student);
            Assert.AreEqual("Pero je student 2. godine diplomskog studija", cw?.GetString());
        }

        [TestMethod]
        public void OsobaStudentPrveGodineDiplomskogStudija()
        {
            GrananjeSwitchSObrascima.IspišiOsobu(student);
            Assert.AreEqual("Student: Pero, 1. godina", cw?.GetString());
        }

        [TestMethod]
        public void OsobaStudentTrećeGodineDiplomskogStudija()
        {
            student.PoložiGodinu();
            student.PoložiGodinu();
            GrananjeSwitchSObrascima.IspišiOsobu(student);
            Assert.AreEqual("Student: Pero, 3. godina", cw?.GetString());
        }

        [TestMethod]
        public void OsobaStudentDiplomirao()
        {
            student.PoložiGodinu();
            student.PoložiGodinu();
            student.PoložiGodinu();
            student.PoložiGodinu();
            GrananjeSwitchSObrascima.IspišiOsobu(student);
            Assert.AreEqual("Student: Pero je diplomirao", cw?.GetString());
        }

        [TestMethod]
        public void ImeOsobe()
        {
            Osoba o = new Osoba("Hrvoje");
            GrananjeSwitchSObrascima.IspišiOsobu(o);
            Assert.AreEqual("Osoba: Hrvoje", cw?.GetString());
        }
    }
}
