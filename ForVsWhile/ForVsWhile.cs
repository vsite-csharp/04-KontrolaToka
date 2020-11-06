using System;

namespace Vsite.CSharp.KontrolaToka
{
    class ForVsWhile
    {
        public static void PetljaFor(int n)
        {
            // Napisati petlju for koja će ispisati brojeve od 0 do (uključivo) n
            for (int i = 0; i <= n; i++)
                Console.WriteLine(i);
        }

        public static void PetljaWhile(int n)
        {
            // Napisati petlju while koja će ispisati brojeve od 0 do (uključivo) n
            int j = 0;
            while (j <= n)
            {
                Console.WriteLine(j);
                j++;
            }
                
        }

        static void Main(string[] args)
        {
            PetljaFor(10);

            PetljaWhile(10);

            // Prevesti program te programom ILDasm usporediti međukod gornjih metoda

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        // Pokrenuti testove i projeriti prolaze li oba testa u grupi TestForVsWhile
    }
}
