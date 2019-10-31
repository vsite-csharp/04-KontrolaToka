using System;

namespace Vsite.CSharp.KontrolaToka
{
    class UvjetnoPridruživanje
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upiši neki cijeli broj:");
            string unos = Console.ReadLine();

            try
            {
                int broj = int.Parse(unos);

                IspišiParnost.UvjetnimPridruživanjem(broj);

                IspišiParnost.GrananjemIf(broj);

                Console.WriteLine("GOTOVO!!!");
            }
            catch (Exception)
            {
                Console.WriteLine("Neispravan unos, pokušaj ponovo.");
            }

            Console.ReadKey();
        }
    }
}
