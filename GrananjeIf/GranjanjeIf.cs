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

            // 1. provjeriti je li broj paran. 
            if (broj % 2 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa 2");
            }
            //    Ako je broj paran, treba ispisati poruku "broj je djeljiv s 2", a inače će
            // 2. provjeriti je li broj djeljiv s 3. 
            else if (broj % 3 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa 3");
            }
            //    Ako je broj djeljiv, treba ispisati poruku "broj je djeljiv s 3", a inače će
            // 3. provjeriti je li broj djeljiv s 5. 
            else if (broj % 5 == 0)
            {
                Console.WriteLine("Broj je djeljiv sa 5");
            }
            //    Ako je broj djeljiv, treba ispisati poruku "broj je djeljiv s 5", a inače
            // 4. treba ispisati "broj nije djeljiv s 2, 3 niti 5"
            else
            {
                Console.WriteLine("Nije djeljiv ni sa 2 ni sa 3 niti sa 5");
            }
        }
    }
}
