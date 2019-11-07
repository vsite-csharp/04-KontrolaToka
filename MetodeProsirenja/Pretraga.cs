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
            //foreach(var i in nizRiječi)
            //{
            //    if (string.Equals(i, tražena))
            //        return true;
            //}
            return false;
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            return brojevi.Sum();
            int i = 0;
            //foreach(int j in brojevi)
            //{
            //    i += j;
            //}
            //return i;
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            return nizRiječi.Where(i => { return string.Compare(i, graničnaRiječ) > 0; });
            //IList<string> rez = new List<string>();
            //foreach(string i in nizRiječi)
            //{
            //    if(String.Compare(i, graničnaRiječ) > 0)
            //    {
            //        rez.Add(i);
            //    }
            //}
            //return rez;
        }
    }
}
