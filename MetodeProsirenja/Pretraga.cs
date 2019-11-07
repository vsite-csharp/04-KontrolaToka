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
            //foreach (var item in nizRiječi)
            //    if (string.Equals(item,tražena))
            //        return true;
            //return false;

            //ILI

            return nizRiječi.Contains(tražena);

            throw new NotImplementedException();
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            //int rez = 0;
            //foreach (int item in brojevi)
            //    rez += item;
            //return rez;

            //ili

            return brojevi.Sum();

            throw new NotImplementedException();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            //IList<string> rez=new List<string>();
            //foreach (string item in nizRiječi)
            //    if (String.Compare(item, graničnaRiječ) > 0)
            //        rez.Add(item);

            //return rez;

            //ili

            return nizRiječi.Where(item => { return string.Compare(item, graničnaRiječ) > 0; });

            throw new NotImplementedException();
        }
    }
}
