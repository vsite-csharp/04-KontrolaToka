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
            //foreach (string s in nizRiječi)
            //    if (string.Compare(s, tražena) == 0)
            //        return true;
            //return false;
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            return brojevi.Sum();
            //int result = 0;
            //foreach (int i in brojevi)
            //    result += i;
            //return result;
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            return nizRiječi.Where(riječ => { return string.Compare(riječ, graničnaRiječ) > 0; });
            //List<string> list = new List<string>();
            //foreach (string s in nizRiječi)
            //    if (string.Compare(s, graničnaRiječ) > 0)
            //        list.Add(s);
            //return list;
        }
    }
}
