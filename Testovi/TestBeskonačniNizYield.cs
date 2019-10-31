namespace Vsite.CSharp.KontrolaToka.Testovi
{
    [TestClass]
    public class TestBeskonačniNizYield
    {
        [TestMethod]
        public void BeskonačniNizSlučajnihBrojevaZaZadanuKlicuDajeOdgovarajućiSlijedSlučajnihBrojeva()
        {
            int klica = 5;
            Random slučajni = new Random(klica);
            var beskonačniNiz = NeograničeniNizYield.NizSlučajnihBrojeva(klica);
            // provjera da rezultat nije neka kolekcija
            Assert.IsTrue(beskonačniNiz.GetType().GetProperty("Count") == null && beskonačniNiz.GetType().GetProperty("Length") == null);
            for (int i = 0; i < 1000; ++i)
            {
                Assert.AreEqual(slučajni.NextDouble(), beskonačniNiz.ElementAt(i));
            }
        }
    }
}
