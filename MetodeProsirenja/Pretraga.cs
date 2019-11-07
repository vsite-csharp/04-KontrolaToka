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
            // TODO:120 Napisati kod koji će vratiti true ako nizRiječi sadrži riječ tražena, a u protivnom vraća false
            foreach (string str in nizRiječi)
                if (str.Equals(tražena))
                    return true;
            return false;
            throw new NotImplementedException();
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            // TODO:121 Napisati kod koji će zbrojiti sve članove kolekcije cijelih brojeva i vratiti taj zbroj kao rezultat
            int sum = 0;
            foreach (int br in brojevi)
                sum += br;
            return sum;
            throw new NotImplementedException();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            // TODO:122 Napisati kod koji će naći sve riječi iz kolekcije nizRiječi koje su abecedno iza riječi graničnaRiječ
            List<string> alpha = new List<string>();
            foreach (string str in nizRiječi) {
                if (String.Compare(str, graničnaRiječ) == 1) {
                    alpha.Add(str);
                }
            }
            return alpha;
            throw new NotImplementedException();
        }
    }
}
