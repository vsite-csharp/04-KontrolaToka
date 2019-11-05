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
            foreach(var i in nizRiječi)
            {
                if (string.Equals(i, tražena))
                    return true;
            }
            return false;
            throw new NotImplementedException();
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            int i = 0;
            foreach(int j in brojevi)
            {
                i += j;
            }
            return i;
            throw new NotImplementedException();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            IList<string> rez = new List<string>();

            foreach(string i in nizRiječi)
            {
                if(String.Compare(i, graničnaRiječ) > 0)
                {
                    rez.Add(i);
                }
            }
            return rez;
            throw new NotImplementedException();
        }
    }
}
