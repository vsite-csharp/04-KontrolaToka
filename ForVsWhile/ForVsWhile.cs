using System;

namespace Vsite.CSharp.KontrolaToka
{
    class ForVsWhile
    {
        public static void PetljaFor(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PetljaWhile(int n)
        {
            int i = 0;
            while (i<=n)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void Main(string[] args)
        {
            PetljaFor(10);

            PetljaWhile(10);

            // TODO:082 Prevesti program te programom ILDasm usporediti međukod gornjih metoda

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
