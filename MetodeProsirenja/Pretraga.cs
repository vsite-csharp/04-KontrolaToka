namespace Vsite.CSharp.KontrolaToka
{
    static class Pretraga
    {
        public static bool Sadrži(IEnumerable<string> nizRiječi, string tražena)
        {
           return nizRiječi.Contains(tražena);
          //  foreach (var rijec in nizRiječi)
          //  {
           //     if (rijec==tražena)
             //   {
           //         return true;
            //    }
           // }
           // return false;
            // :120 Napisati kod koji će vratiti true ako nizRiječi sadrži riječ tražena, a u protivnom vraća false
            // (za jednostavnije rješenje, pogledati https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable)

            
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
           return brojevi.Sum();
            // :121 Napisati kod koji će zbrojiti sve članove kolekcije cijelih brojeva i vratiti taj zbroj kao rezultat

            throw new NotImplementedException();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            return nizRiječi.Where(clan => string.Compare(clan, graničnaRiječ)>0);

            // :122 Napisati kod koji će naći sve riječi iz kolekcije nizRiječi koje su abecedno iza riječi graničnaRiječ

            throw new NotImplementedException();
        }

        // :123 Pokrenuti program i provjeriti ispise
        
        // :124 Pokrenuti testove i provjeriti prolaze li svi testovi u grupi TestMetodaProširenja
    }
}
