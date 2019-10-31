﻿namespace Vsite.CSharp.KontrolaToka
{
    static class GranjanjeIf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši neki cijeli broj:");
            var unos = Console.ReadLine();

            try
            {
                int broj = int.Parse(unos!);
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
            // TODO:010 Napisati grananja if koja će za uneseni broj:
            // 1. provjeriti je li broj paran. 
            //    Ako je broj paran, treba ispisati poruku "broj je djeljiv s 2", a inače će
            // 2. provjeriti je li broj djeljiv s 3. 
            //    Ako je broj djeljiv, treba ispisati poruku "broj je djeljiv s 3", a inače će
            // 3. provjeriti je li broj djeljiv s 5. 
            //    Ako je broj djeljiv, treba ispisati poruku "broj je djeljiv s 5", a inače
            // 4. treba ispisati "broj nije djeljiv s 2, 3 niti 5"

            // TODO:011 Pokrenuti program nekoliko puta i upisom različitih brojeva provjeriti ispravnost koda

            // TODO:012 Pokrenuti testove i provjeriti prolaze li 4 testa iz grupe TestGrananjaIf
        }
    }
}
