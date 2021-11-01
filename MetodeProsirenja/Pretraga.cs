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
            //110 Napisati kod koji će vratiti true ako nizRiječi sadrži riječ tražena, a u protivnom vraća false
            // (za jednostavnije rješenje, pogledati https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable)
            try
            {
                if (nizRiječi.Contains(tražena))
                    return true;
                else
                    return false;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            //111 Napisati kod koji će zbrojiti sve članove kolekcije cijelih brojeva i vratiti taj zbroj kao rezultat
            try
            {
                return brojevi.Sum();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            //112 Napisati kod koji će naći sve riječi iz kolekcije nizRiječi koje su abecedno iza riječi graničnaRiječ
            try
            {
                IEnumerable<string> newElements;
                List<string> list = new List<string>();
                foreach (var el in (nizRiječi.OrderBy(s => s)))
                {
                    if (string.Compare(el, graničnaRiječ) > 0)
                        list.Add(el);
                }

                newElements = (IEnumerable<string>)(list);
                return newElements;
            }
            catch
            {
                throw new NotImplementedException();
            }
           
        }

        //113 Pokrenuti program i provjeriti ispise
        
        //114 Pokrenuti testove i provjeriti prolaze li svi testovi u grupi TestMetodaProširenja
    }
}
