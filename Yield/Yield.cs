using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.KontrolaToka
{
    class Yield
    {
        static void Main(string[] args)
        {
            foreach (var kvadrat in DajKvadrate())
                Console.WriteLine(kvadrat);

            var niz1 = FibonacciList();
            foreach (var broj in niz1)
                Console.WriteLine(broj);

            var niz2 = FibonacciIEnumerable();
            foreach (var broj in niz2)
                Console.WriteLine(broj);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        static IEnumerable<int> DajKvadrate()
        {
            yield return 0;
            yield return 1;
            yield return 4;
            yield return 9;
            yield return 16;
            yield return 25;
        }

        public static IList<int> FibonacciList()
        {
            List<int> rezultat = new List<int>();
            rezultat.Add(0);
            rezultat.Add(1);

            int prethodni = 0;
            int trenutni = 1;
            while (prethodni < int.MaxValue / 2)
            {
                // TODO:120 Promijenite petlju tako da se unutar petlje provjerava je li donja operacija bacila OverflowException i u tom slučaju prekida petlju
                // U postavkama projekta uključiti opciju za provjeru numeričkog preljeva i pokrenuti program.
                int zbroj = prethodni + trenutni;
                prethodni = trenutni;
                trenutni = zbroj;
                rezultat.Add(trenutni);
            }
            return rezultat;
        }

        // TODO:121 Implementirajte donju metodu korištenjem koda gornje metode FibonacciList
        public static IEnumerable<int> FibonacciIEnumerable()
        {
            throw new NotImplementedException();
        }

        // TODO:122 Pokrenuti testove i provjeriti prolaze li svi testovi iz grupe TestYield
    }
}
