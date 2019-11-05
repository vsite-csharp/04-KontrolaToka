using System;

namespace Vsite.CSharp.KontrolaToka
{
    class ForVsWhile
    {
        public static void PetljaFor(int n)
        {
            for(int i = 0; i <= n; ++i)
            {
                Console.Write(i); Console.Write(" ");
            }
            Console.WriteLine();
        }

        public static void PetljaWhile(int n)
        {
            int i = 0;
            while(i <= 10)
            {
                Console.Write(i); Console.Write(" ");
                ++i;
            }
            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            PetljaFor(10);

            PetljaWhile(10);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
