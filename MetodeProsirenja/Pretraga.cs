﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.KontrolaToka
{
    class Pretraga
    {
        public static bool Sadrži(IEnumerable<string> nizRiječi, string tražena)
        {
            // :110 Napisati kod koji će vratiti true ako nizRiječi sadrži riječ tražena, a u protivnom vraća false
            // (za jednostavnije rješenje, pogledati https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable)
            foreach (var rijec in nizRiječi)
            {
                if (rijec.Equals(tražena))
                    return true;
            }

            return false;
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            // :111 Napisati kod koji će zbrojiti sve članove kolekcije cijelih brojeva i vratiti taj zbroj kao rezultat
            var zbroj = 0;
            foreach (var broj in brojevi)
            {
                zbroj += broj;
            }

            return zbroj;
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            // :112 Napisati kod koji će naći sve riječi iz kolekcije nizRiječi koje su abecedno iza riječi graničnaRiječ
            var podniz = new List<string>();
            foreach (var riječ in nizRiječi)
            {
                if (riječ.CompareTo(graničnaRiječ) > 0)
                    podniz.Add(riječ);
            }
            return podniz;
        }

        // :113 Pokrenuti program i provjeriti ispise
        
        // :114 Pokrenuti testove i provjeriti prolaze li svi testovi u grupi TestMetodaProširenja
    }
}
