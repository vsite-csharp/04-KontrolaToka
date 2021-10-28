using System;
using System.Collections;
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
            foreach (IEnumerable item in nizRiječi)
            {
                if (item.ToString() == tražena) { return true; }
            }
            return false;
            throw new NotImplementedException();
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            // 111 Napisati kod koji će zbrojiti sve članove kolekcije cijelih brojeva i vratiti taj zbroj kao rezultat
            int zbroj = 0;
            foreach (int i in brojevi)
            {
                zbroj += i;
            }
            return zbroj;
            //throw new NotImplementedException();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            // 112 Napisati kod koji će naći sve riječi iz kolekcije nizRiječi koje su abecedno iza riječi graničnaRiječ
            String rez;
            String temp;
            foreach (var item in nizRiječi)
            {
                //rez += temp;
                if (String.Compare(item.ToString(), graničnaRiječ) > 0)
                {
                    Console.WriteLine(item);
                    yield return item;
                }
            }
            yield break;
            throw new NotImplementedException();
        }

        // TODO:113 Pokrenuti program i provjeriti ispise
        
        // TODO:114 Pokrenuti testove i provjeriti prolaze li svi testovi u grupi TestMetodaProširenja
    }
}
