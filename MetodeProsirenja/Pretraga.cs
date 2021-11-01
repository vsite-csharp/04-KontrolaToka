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
            //:110 Napisati kod koji će vratiti true ako nizRiječi sadrži riječ tražena, a u protivnom vraća false
            // (za jednostavnije rješenje, pogledati https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable)
            foreach(string el in nizRiječi)
            {
                if (el.ToLower() == tražena.ToLower())
                {
                    return true;
                }
            }
            return false;
            //throw new NotImplementedException();
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            //:111 Napisati kod koji će zbrojiti sve članove kolekcije cijelih brojeva i vratiti taj zbroj kao rezultat
            int suma = 0;
            foreach(int el in brojevi)
            {
                suma += el;
            }
            return suma;
            //throw new NotImplementedException();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            //:112 Napisati kod koji će naći sve riječi iz kolekcije nizRiječi koje su abecedno iza riječi graničnaRiječ
            int counter = 0;
            var temp = nizRiječi.ToList();
            List<int> to_del = new List<int>();
            foreach(string el in nizRiječi)
            {
                if (el.CompareTo(graničnaRiječ)<0)
                {
                    temp.RemoveAt(counter);
                    continue;
                }
                counter++;
            }
            return temp;
            //throw new NotImplementedException();
        }

        //:113 Pokrenuti program i provjeriti ispise
        
        //:114 Pokrenuti testove i provjeriti prolaze li svi testovi u grupi TestMetodaProširenja
    }
}
