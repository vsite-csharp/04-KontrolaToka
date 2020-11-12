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
            return nizRiječi.Contains(tražena);
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            return brojevi.Sum();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            return nizRiječi.Where(rijec => rijec.CompareTo(graničnaRiječ) > 0);
        }

        // TODO:113 Pokrenuti testove i provjeriti prolaze li svi testovi u grupi TestMetodaProširenja
    }
}
