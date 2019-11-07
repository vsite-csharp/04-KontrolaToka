using System;

namespace Vsite.CSharp.KontrolaToka
{
    class ForVsWhile
    {
        public static void PetljaFor(int n)
        {
            for (int i = 0; i <= n; ++i)
                Console.WriteLine(i);
        }

        public static void PetljaWhile(int n)
        {
            int i = 0;
            while ( n >= i)
                Console.WriteLine(i++);
        }

        static void Main(string[] args)
        {
            PetljaFor(10);

            PetljaWhile(10);

            //ako sam dobro vidio, međukod je isti u ildasm

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
