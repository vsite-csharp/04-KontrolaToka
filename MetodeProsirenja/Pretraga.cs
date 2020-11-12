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
            //  Napisati kod koji će vratiti true ako nizRiječi sadrži riječ tražena, a u protivnom vraća false
            // (za jednostavnije rješenje, pogledati https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable)

            //foreach (var rijec in nizRiječi)
            //{
            //    if(rijec == tražena)
            //        return true;
            //}
            //    return false;

            //throw new NotImplementedException();

            return nizRiječi.Contains(tražena);
        }
        public static int Zbroj(IEnumerable<int> brojevi)
        {
            // Napisati kod koji će zbrojiti sve članove kolekcije cijelih brojeva i vratiti taj zbroj kao rezultat
           return  brojevi.Sum();
            //throw new /*NotImplementedException*/();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            List<string> rez = new List<string>();

            foreach(var rijec in nizRiječi)
            {
                if (rijec.CompareTo(graničnaRiječ) > 0)
                {
                    rez.Add(rijec);
                }
            }
            // Napisati kod koji će naći sve riječi iz kolekcije nizRiječi koje su abecedno iza riječi graničnaRiječ
            nizRiječi.Where(r => r.CompareTo(graničnaRiječ) > 0; /*lambda*/
            throw new NotImplementedException();
        }

        //  Pokrenuti testove i provjeriti prolaze li svi testovi u grupi TestMetodaProširenja
    }
}
