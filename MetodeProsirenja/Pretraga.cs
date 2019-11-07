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
            return nizRiječi.Contains(tražena);    //vraća bool
            //foreach (var rijec in nizRiječi)
            //{
            //    if (string.Compare(rijec, tražena) == 0)
            //        return true;
            //}
            //return false;
            //throw new NotImplementedException();
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            return brojevi.Sum();
            //int zbroj = 0;
            //foreach (var br in brojevi)
            //    zbroj += br;
            //return zbroj;
            //throw new NotImplementedException();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            return nizRiječi.Where(riječ => { return string.Compare(riječ, graničnaRiječ) > 0;});  //lambda funkcija
            //List<string> lista = new List<string>();
            //foreach (string rijec in nizRiječi)
            //    if (string.Compare(rijec, graničnaRiječ) > 1) 
            //        lista.Add(rijec);

            //return lista; 
         
        }
    }
}
