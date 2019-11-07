using System;

namespace Vsite.CSharp.KontrolaToka
{
    class ForVsWhile
    {
        public static void PetljaFor(int n)
        {
            for (int i = 0; i >= n; i++)
                Console.WriteLine(i);
        }

        public static void PetljaWhile(int n)
        {
            int i = 0;
            while(i <= n){
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            PetljaFor(10);

            PetljaWhile(10);
            //metode rade istim načinom

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
