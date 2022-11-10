﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.KontrolaToka
{
    class Yield
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kvadrati brojeva:");
            // 120 Postaviti prekidnu točku (breakpoint) na 'in' u donjoj petlji foreach, pokrenuti program i nakon svakog prekida napraviti 'Step Into' (F11) i pratiti izvođenje metode DajKvadrat
            foreach (var kvadrat in DajKvadrate())
                Console.WriteLine(kvadrat);

            Console.WriteLine();
            Console.WriteLine("Fibonaccijev niz preko liste:");
            var niz1 = FibonacciList();
            foreach (var broj in niz1)
                Console.WriteLine(broj);

            Console.WriteLine();
            Console.WriteLine("Fibonaccijev niz pomoću yielda:");
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
        }

        public static IList<int> FibonacciList()
        {
            List<int> rezultat = new List<int>();
            return  rezultat;   
           
        }

        // TODO:122 Implementirajte donju metodu korištenjem koda gornje metode FibonacciList
        public static IEnumerable<int> FibonacciIEnumerable()
        {
            yield return 0;
            yield return 1;

            int prethodni = 0;
            int trenutni = 1;

            while (prethodni < int.MaxValue / 2)
            {
                int zbroj = prethodni;
                try
                {
                    zbroj += trenutni;
                }
                catch (OverflowException)
                {
                    yield break;
                }
                prethodni = trenutni;
                trenutni = zbroj;
                yield return trenutni;
            }

        }

        // 123 Pokrenuti program i provjeriti ispise

        // TODO:124 Pokrenuti testove i provjeriti prolaze li svi testovi iz grupe TestYield
    }
}
