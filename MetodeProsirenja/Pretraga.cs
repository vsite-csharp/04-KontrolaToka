using System.Collections;
using System.Collections.Immutable;

namespace Vsite.CSharp.KontrolaToka
{
    static class Pretraga
    {
        public static bool Sadrži(IEnumerable<string> nizRiječi, string tražena)
        {
            // :110 Napisati kod koji će vratiti true ako nizRiječi sadrži riječ tražena, a u protivnom vraća false
            // (za jednostavnije rješenje, pogledati https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable)
            return nizRiječi.Contains<string>(tražena);

        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            // :111 Napisati kod koji će zbrojiti sve članove kolekcije cijelih brojeva i vratiti taj zbroj kao rezultat
            //int sum = 0;
            //foreach(int i in brojevi)
            //{
            //    sum += i;
            //}
            //return sum;

            return brojevi.Sum();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            List<string> Pronađene = new List<string>();
            // :112 Napisati kod koji će naći sve riječi iz kolekcije nizRiječi koje su abecedno iza riječi graničnaRiječ

            foreach (var item in nizRiječi)
            {
                if(String.Compare(item, graničnaRiječ) > 0)
                {
                    Console.WriteLine(item);
                    Pronađene.Add(item);
                }
            }

            return Pronađene;

            //throw new NotImplementedException();
        }

        // :113 Pokrenuti program i provjeriti ispise
        
        // :114 Pokrenuti testove i provjeriti prolaze li svi testovi u grupi TestMetodaProširenja
    }
}
