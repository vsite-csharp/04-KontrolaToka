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
            // Napisati kod koji će vratiti true ako nizRiječi sadrži riječ tražena, a u protivnom vraća false
            return nizRiječi.Contains(tražena);
            // (za jednostavnije rješenje, pogledati https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable)
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            // Napisati kod koji će zbrojiti sve članove kolekcije cijelih brojeva i vratiti taj zbroj kao rezultat
            int zbroj = 0;
            foreach (var broj in brojevi)
            {
                zbroj += broj;
            }

            return zbroj;
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            // Napisati kod koji će naći sve riječi iz kolekcije nizRiječi koje su abecedno iza riječi graničnaRiječ
            var rješenje = new List<string>();

            foreach (var riječ in nizRiječi)
            {
                string kraćaRiječ = riječ.Length < graničnaRiječ.Length ? riječ : graničnaRiječ;
                for (int i = 0; i < kraćaRiječ.Length; i++)
                {
                    if (riječ[i] != graničnaRiječ[i])
                    {
                        if (riječ[i] > graničnaRiječ[i])
                        {
                            rješenje.Add(riječ);
                        }

                        break;
                    }
                }
            }

            return rješenje;
        }

        // Pokrenuti program i provjeriti ispise
        
        // Pokrenuti testove i provjeriti prolaze li svi testovi u grupi TestMetodaProširenja
    }
}
