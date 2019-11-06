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
            foreach(string target in nizRiječi)
            {
                if (string.Equals(target,tražena))
                    return true;
            }
            return false;
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            int zbroj = 0;
            foreach (int num in brojevi)
            {
                zbroj += num;
            }
            return zbroj;
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            IList<string> output = new List<string>();
            foreach(string word in nizRiječi)
            {
                if (string.Compare(word,graničnaRiječ) > 0)
                    output.Add(word);
            }
            return output;
        }
    }
}
