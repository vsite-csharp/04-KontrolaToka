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
            Console.WriteLine("Kvadrati brojeva:");
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
            rezultat.Add(0);
            rezultat.Add(1);

            int prethodni = 0;
            int trenutni = 1;
            while (true)//(prethodni < int.MaxValue / 2)
            {
                try
                {
                    int zbroj = prethodni + trenutni;
                    prethodni = trenutni;
                    trenutni = zbroj;
                    rezultat.Add(trenutni);
                }
                catch (OverflowException)
                {
                    return rezultat;
                }
                
            }
        }

        
        public static IEnumerable<int> FibonacciIEnumerable()
        {
        
            yield return 0;
            yield return 1;

            int prethodni = 0;
            int trenutni = 1;
            while (true)//(prethodni < int.MaxValue / 2)
            {
                try
                {
                    int zbroj = prethodni + trenutni;
                    prethodni = trenutni;
                    trenutni = zbroj;
                }
                catch (OverflowException)
                {
                    yield break;
                }
                yield return trenutni;

            }
            
        }

        
    }
}
