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
            foreach (var rijec in nizRiječi)
            {
                if (rijec.Equals(tražena))
                    return true;
                else
                    return false;
            }
            throw new NotImplementedException();
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            int zbroj = 0;
            foreach (var br in brojevi)
                zbroj = +br;
            return zbroj;
            throw new NotImplementedException();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            List<string> lista = new List<string>();
            foreach (string rijec in nizRiječi)
                if (String.Compare(rijec, graničnaRiječ) == 1) 
                    lista.Add(rijec);

            return lista; 
            throw new NotImplementedException();
        }
    }
}
