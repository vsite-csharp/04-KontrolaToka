namespace Vsite.CSharp.KontrolaToka
{
    static class Pretraga
    {
        public static bool Sadrži(IEnumerable<string> nizRiječi, string tražena)
        {
            // TODO:120 Napisati kod koji će vratiti true ako nizRiječi sadrži riječ tražena, a u protivnom vraća false
            // (za jednostavnije rješenje, pogledati https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable)
            //foreach(var rijec in nizRiječi)
            //{
            //    if (rijec == tražena) return true;
            //}
            //return false;
            return nizRiječi.Contains(tražena);

            throw new NotImplementedException();
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            // TODO:121 Napisati kod koji će zbrojiti sve članove kolekcije cijelih brojeva i vratiti taj zbroj kao rezultat
            return brojevi.Sum();

            throw new NotImplementedException();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            // TODO:122 Napisati kod koji će naći sve riječi iz kolekcije nizRiječi koje su abecedno iza riječi graničnaRiječ
            return nizRiječi.Where(clan => string.Compare(clan, graničnaRiječ, true) > 0);

            throw new NotImplementedException();
        }

        // TODO:123 Pokrenuti program i provjeriti ispise
        
        // TODO:124 Pokrenuti testove i provjeriti prolaze li svi testovi u grupi TestMetodaProširenja
    }
}
