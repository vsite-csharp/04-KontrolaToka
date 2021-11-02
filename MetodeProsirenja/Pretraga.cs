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
            if (nizRiječi.Contains(tražena))
                return true;
            else
                return false;
            // (za jednostavnije rješenje, pogledati https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable)

            throw new NotImplementedException();
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            // 111 Napisati kod koji će zbrojiti sve članove kolekcije cijelih brojeva i vratiti taj zbroj kao rezultat
            //int zbroj = 0;
            //foreach (var broj in brojevi)
            //{
            //    zbroj = zbroj + broj;
            //}
            //return zbroj;

            return brojevi.Sum();
            throw new NotImplementedException();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            // 112 Napisati kod koji će naći sve riječi iz kolekcije nizRiječi koje su abecedno iza riječi graničnaRiječ
            IEnumerable<string> novaKolekcija = new string[] { };
            foreach (var riječ in nizRiječi)
            {
                if (riječ.CompareTo(graničnaRiječ) >0)
                {
                    novaKolekcija = novaKolekcija.Concat(new[] { riječ });
                }
            }

            return novaKolekcija;
            throw new NotImplementedException();
        }

        // 113 Pokrenuti program i provjeriti ispise
        
        // 114 Pokrenuti testove i provjeriti prolaze li svi testovi u grupi TestMetodaProširenja
    }
}
