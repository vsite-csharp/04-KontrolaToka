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
            //foreach(string riječ in nizRiječi)
            //{
            //    if(riječ == tražena) return true;
            //}
            //return false;

            // (za jednostavnije rješenje, pogledati https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable)
            return nizRiječi.Contains(tražena);
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            // Napisati kod koji će zbrojiti sve članove kolekcije cijelih brojeva i vratiti taj zbroj kao rezultat
            //int zbroj = 0;
            //foreach(int broj in brojevi)
            //{
            //    zbroj += broj;
            //}
            //return zbroj;
            return brojevi.Sum();

        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            // Napisati kod koji će naći sve riječi iz kolekcije nizRiječi koje su abecedno iza riječi graničnaRiječ
            IEnumerable<string> noviNizRiječi = nizRiječi.Where(riječ => riječ.CompareTo(graničnaRiječ) > 0);
            return noviNizRiječi;

        }

        // Pokrenuti program i provjeriti ispise

        // Pokrenuti testove i provjeriti prolaze li svi testovi u grupi TestMetodaProširenja
    }
}
