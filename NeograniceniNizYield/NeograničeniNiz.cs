using System;
using System.Collections.Generic;

namespace Vsite.CSharp.KontrolaToka
{
    class NeograničeniNizYield
    {
        const int granica = 10;
        const int klica = 5;

        private static void RandomBezKlice()
        {
            // primjer korištenja klase Random bez klice
            Console.WriteLine("Niz brojeva koje klasa Random generira bez klice:");
            Random slučajni = new Random();
            for (int i = 0; i < granica; ++i)
                Console.WriteLine(slučajni.NextDouble());
        }

        private static void RandomSKlicom()
        {
            // primjer korištenja klase Random sa zadanom klicom
            Console.WriteLine($"Niz brojeva koje klasa Random generira s klicom {klica}:");
            Random slučajni = new Random(klica);
            for (int i = 0; i < granica; ++i)
                Console.WriteLine(slučajni.NextDouble());
        }

        static void Main(string[] args)
        {
            RandomBezKlice();

            Console.WriteLine();

            RandomSKlicom();

            Console.WriteLine();


            //prva petlja
            //korištenjem brojača ćemo (ipak) ograničiti broj ispisanih elemenata liste
            int brojač = 0;
            Console.WriteLine($"Niz pseudoslučajnih brojeva bez klice:");
            foreach (var broj in NizSlučajnihBrojeva())
            {
                if (++brojač > granica)
                    break;
                Console.WriteLine(broj);
            }

            Console.WriteLine();
            //druga petlja
            brojač = 0;
            Console.WriteLine($"Niz pseudoslučajnih brojeva s klicom: {klica}");
            foreach (var broj in NizSlučajnihBrojeva(klica))
            {
                if (++brojač > granica)
                    break;
                Console.WriteLine(broj);
            }

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        // Implementirati metodu tako da omogućava vraćanje beskonačnog niza slučajnih brojeva. 
        //          Otkomentirati prvu petlju gore i provjeriti ispravnost implementacije.
        public static IEnumerable<double> NizSlučajnihBrojeva()
        {
            while(true)
            {
                Random randbroj = new Random();
                System.Threading.Thread.Sleep(30);
                yield return randbroj.NextDouble();
            }
            
        }

        // Implementirati metodu tako da omogućava vraćanje beskonačnog niza slučajnih brojeva uz zadanu početnu klicu.
        //          Otkomentirati drugu petlju gore i provjeriti ispravnost implementacije.
        public static IEnumerable<double> NizSlučajnihBrojeva(int klica)
        {
            Random randbroj = new Random(klica);
            while (true)
            {
                yield return randbroj.NextDouble();
             
            }
        }
    }
}
