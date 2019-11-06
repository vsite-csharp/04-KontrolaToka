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
                if (target.Equals(nizRiječi))
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
            // TODO:122 Napisati kod koji će naći sve riječi iz kolekcije nizRiječi koje su abecedno iza riječi graničnaRiječ

            throw new NotImplementedException();
        }
    }
}
