using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.KontrolaToka
{
    class Pretraga
    {
        public static bool Sadrži(IEnumerable<string> nizRiječi, string tražena)
        {
            // 110 Napisati kod koji će vratiti true ako nizRiječi sadrži riječ tražena, a u protivnom vraća false
            // (za jednostavnije rješenje, pogledati https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable)
            foreach (var riječ in nizRiječi)
            {
                if (riječ == tražena)
                {
                    return true;
                }
            }

            return false;
            //return nizRiječi.Contains(tražena);
            //throw new NotImplementedException();
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            // 111 Napisati kod koji će zbrojiti sve članove kolekcije cijelih brojeva i vratiti taj zbroj kao rezultat
            int zbroj = 0;
            foreach (var broj in brojevi)
            {
                zbroj += broj;
            }

            return zbroj;
            //throw new NotImplementedException();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            // 112 Napisati kod koji će naći sve riječi iz kolekcije nizRiječi koje su abecedno iza riječi graničnaRiječ
            List<string> sviIza = new List<string>();
            foreach (var riječ in nizRiječi)
            {
                int n = Math.Min(graničnaRiječ.Length, riječ.Length);
                for (int i = 0; i < n; i++)
                {
                    if (graničnaRiječ[i] < riječ[i])
                    {
                        sviIza.Add(riječ);
                        break;
                    }
                    if (graničnaRiječ[i] > riječ[i])
                    {
                        break;
                    }
                }
            }

            return sviIza;
            //throw new NotImplementedException();
        }

        // 113 Pokrenuti program i provjeriti ispise
        
        // 114 Pokrenuti testove i provjeriti prolaze li svi testovi u grupi TestMetodaProširenja
    }
}
