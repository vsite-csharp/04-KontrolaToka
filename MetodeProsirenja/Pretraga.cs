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
            //foreach (string str in nizRiječi)
            //    if (str.Equals(tražena))
            //        return true;
            //return false;
            //throw new NotImplementedException();
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            return brojevi.Sum();
            //int sum = 0;
            //foreach (int br in brojevi)
            //    sum += br;
            //return sum;
            //throw new NotImplementedException();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            return nizRiječi.Where(rijec => { return string.Compare(rijec, graničnaRiječ) > 0; });
            //List<string> alpha = new List<string>();
            //foreach (string str in nizRiječi) {
            //    if (String.Compare(str, graničnaRiječ) == 1) {
            //        alpha.Add(str);
            //    }
            //}
            //return alpha;
        }
    }
}
