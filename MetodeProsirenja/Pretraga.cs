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
            return nizRiječi.Contains(tražena);
            //    foreach (string riječ in nizRiječi)
            //    {
            //        if (string.Compare(riječ, tražena) == 0)
            //            return true;
            //        
            //            
            //    }
           //      return false;
            throw new NotImplementedException();
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            // TODO:121 Napisati kod koji će zbrojiti sve članove kolekcije cijelih brojeva i vratiti taj zbroj kao rezultat
            return brojevi.Sum();
            //int zbroj =0;
            //foreach (int broj in brojevi)
            //{
            //    zbroj += broj;
                
            //}
            //return zbroj;
            throw new NotImplementedException();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            // TODO:122 Napisati kod koji će naći sve riječi iz kolekcije nizRiječi koje su abecedno iza riječi graničnaRiječ
            return nizRiječi.Where(riječ => { return string.Compare(riječ, graničnaRiječ) > 0; });
            //List<string> rezultat = new List<string>();
            //foreach (string riječ in nizRiječi)     
            //{
            //    if (string.Compare(riječ, graničnaRiječ) > 0)
            //        rezultat.Add(riječ);
            //}
            //return rezultat;
            throw new NotImplementedException();
        }
    }
}
