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
            return nizRiječi.Any(rijec => rijec == tražena);
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            return brojevi.Aggregate(func: (result, item) => result + item);
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            return nizRiječi.Where(rijec => rijec.CompareTo(graničnaRiječ) > 0);
        }
    }
}
