using System;

namespace Vsite.CSharp.KontrolaToka
{
    class ForVsWhile
    {
        public static void PetljaFor(int n)
        {
            for(int i=0; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PetljaWhile(int n)
        {
            int i = 0;
            while(i <= n)
            {
                Console.WriteLine(i++);
            }
            //Random rand = new Random();
            //int a = 0;
            //while ((a = rand.Next(5)) != 0)
            //{
            //    Console.WriteLine(a);
            //}

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
