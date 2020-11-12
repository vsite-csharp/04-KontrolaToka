using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Vsite.CSharp.KontrolaToka
{
    class Pretraga
    {
        public static bool Sadrži(IEnumerable<string> nizRiječi, string tražena)
        {
            // (za jednostavnije rješenje, pogledati https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable)
            //foreach(var riječ in nizRiječi)
            //{
            //    if (riječ == tražena)
            //        return true;
            //}
            //return false;
            return nizRiječi.Contains(tražena);
            //throw new NotImplementedException();
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            return brojevi.Sum();
            //throw new NotImplementedException();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> nizRiječi, string graničnaRiječ)
        {
            return nizRiječi.Where(riječ => riječ.CompareTo(graničnaRiječ) > 0);
            //throw new NotImplementedException();
        }

    }
}
