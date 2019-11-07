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
            //foreach (string riječ in nizRiječi)
            //{
             //   if (string.Compare(riječ, tražena) == 0)
             //       return true;
           // }
          //  return false;
            throw new NotImplementedException();
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            
            return brojevi.Sum();
            //int zbroj = 0;
            //foreach (var broj in brojevi)
            //    zbroj += broj;
            //return zbroj;
            throw new NotImplementedException();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            
           return nizRiječi.Where(riječ => { return string.Compare(riječ, graničnaRiječ) > 0; });
            //List<string> rezultat = new List<string>();
            //foreach(string riječ in nizRiječi)
            //{
            //    if (string.Compare(riječ, graničnaRiječ) > 0)
            //        rezultat.Add(riječ);
            //}
            throw new NotImplementedException();
        }
    }
}
