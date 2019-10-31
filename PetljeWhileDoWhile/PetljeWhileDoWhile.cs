using System;

namespace Vsite.CSharp.KontrolaToka
{
    class PetljeWhileDoWhile
    {
        public static int BrojBacanjaDoBačeneŠestice()
        {
            Random generatorSlučajnih = new Random(); // generator slučajnih brojeva
            int brojBacanja = 0;
            int bacanje = 0;

            // TODO:090 Napisati petlju koja ispisuje rezultat bacanja sve dok ne padne na 6

            {
                //++brojBacanja;
                bacanje = generatorSlučajnih.Next(1, 7); // generira slučajni broj između 1 i 6
                Console.WriteLine("{0}. pokušaj: {1}", brojBacanja, bacanje);
            }

            return brojBacanja;
        }

        public static int BacajDokNeProđe12Polja(int brojPređenihPolja)
        {
            Random generatorSlučajnih = new Random(); // generator slučajnih brojeva

            // TODO:091 Napisati petlju koja se ponavlja sve dok brojPređenihPolja ne postane jednak ili veći od 12

            {
                int bacanje = generatorSlučajnih.Next(1, 7); // generira slučajni broj između 1 i 6
                Console.WriteLine($"Bacanje: {bacanje}");
                brojPređenihPolja += bacanje;
                Console.WriteLine($"Ukupno: {brojPređenihPolja}");
            }
            return brojPređenihPolja;
        }

        static void Main(string[] args)
        {

            int brojPređenihPolja = BrojBacanjaDoBačeneŠestice();

            brojPređenihPolja = BacajDokNeProđe12Polja(brojPređenihPolja);
            Console.WriteLine("Zbroj = {0}", brojPređenihPolja);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
