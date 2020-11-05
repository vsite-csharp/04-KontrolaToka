﻿using System;

namespace Vsite.CSharp.KontrolaToka
{
    class GranjanjeIf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši neki cijeli broj:");
            string unos = Console.ReadLine();

            try
            {
                int broj = int.Parse(unos);
                ProvjeriDjeljivost(broj);

                Console.WriteLine("GOTOVO!");
            }
            catch (Exception)
            {
                Console.WriteLine("Neispravan unos, pokušaj ponovo.");
            }

            Console.ReadKey();
        }

        public static void ProvjeriDjeljivost(int broj)
        {
            // Napisati grananja if koja će za uneseni broj:
            // 1. provjeriti je li broj paran. 
            //    Ako je broj paran, treba ispisati poruku "broj je djeljiv s 2", a inače će
            if (broj % 2 == 0)
                Console.WriteLine("broj je djeljiv s 2");
            // 2. provjeriti je li broj djeljiv s 3. 
            //    Ako je broj djeljiv, treba ispisati poruku "broj je djeljiv s 3", a inače će
            else if(broj%3==0)
                Console.WriteLine("broj je djeljiv s 3");
            // 3. provjeriti je li broj djeljiv s 5. 
            //    Ako je broj djeljiv, treba ispisati poruku "broj je djeljiv s 5", a inače
            else if(broj%5==0)
                Console.WriteLine("broj je djeljiv s 5");
            // 4. treba ispisati "broj nije djeljiv s 2, 3 niti 5"
            else
                Console.WriteLine("broj nije djeljiv s 2, 3 niti 5");
            // Pokrenuti testove i provjertiti prolaze li 4 testa iz grupe TestGrananjaIf
        }
    }
}
