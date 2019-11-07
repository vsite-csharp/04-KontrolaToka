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

            foreach (var broj in FibonacciIEnumerable())
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
            while (true)
            {
                try
                {
                    int zbroj = prethodni + trenutni;
                    prethodni = trenutni;
                    trenutni = zbroj;
                    rezultat.Add(trenutni);
                }
                catch (OverflowException e)
                {
                    break;
                }

            }
            return rezultat;
        }

        public static IEnumerable<int> FibonacciIEnumerable()
        {
            yield return 0;
            yield return 1;
            int prethodni = 0;
            int trenutni = 1;
            while (true)
            {
                try
                {
                    int zbroj = prethodni + trenutni;
                    prethodni = trenutni;
                    trenutni = zbroj;
                }
                catch (OverflowException e)
                {
                    break;
                }
                yield return trenutni;
            }
            yield break;
        }
    }
}
