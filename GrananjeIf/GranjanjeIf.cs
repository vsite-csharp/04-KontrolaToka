using System;

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
            if(broj % 2 == 0)
            {
                Console.WriteLine("Broj {0} je djeljiv sa 2 ", broj);
            }
            else if(broj % 3 == 0)
            {
                Console.WriteLine("Broj {0} je djeljiv sa 3 ", broj);
            }
            else if(broj % 5 == 0)
            {
                Console.WriteLine("Broj {0} je djeljiv sa 5", broj);
            }
            else
            {
                Console.Write("Broj nije djeljiv sa brojevima 2,3,5.");
            }
        }
    }
}
