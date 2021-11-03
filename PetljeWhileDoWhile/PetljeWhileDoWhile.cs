using System;

namespace Vsite.CSharp.KontrolaToka
{
    class PetljeWhileDoWhile
    {
        public static int BrojBacanjaDoBačeneŠestice()
        {
            Random generatorSlučajnih = new Random(); // generator slučajnih brojeva
            int brojBacanja = 0;
            int bačeniBroj = 0;

            // :080 Napisati petlju koja ispisuje rezultat bacanja sve dok ne padne na 6

            while (bačeniBroj != 6) 
            {
                ++brojBacanja;
                bačeniBroj = generatorSlučajnih.Next(1, 7); // generira slučajni broj između 1 i 6
                Console.WriteLine("{0}. pokušaj: {1}", brojBacanja, bačeniBroj);
            }            

            return brojBacanja;
        }

        public static int BacajDokNeProđe12Polja(int brojPređenihPolja)
        {
            Random generatorSlučajnih = new Random(); // generator slučajnih brojeva

            // :081 Napisati petlju koja se ponavlja sve dok brojPređenihPolja ne postane jednak ili veći od 12

            while(brojPređenihPolja < 12)
            {
                int bačeniBroj = generatorSlučajnih.Next(1, 7); // generira slučajni broj između 1 i 6
                Console.WriteLine($"Bacanje: {bačeniBroj}");
                brojPređenihPolja += bačeniBroj;
                Console.WriteLine($"Ukupno: {brojPređenihPolja}");
            }
            return brojPređenihPolja;
        }

        // :082 Pokrenuti testove i provjeriti prolaze li testovi u grupi TestPetljeWhileDoWhile
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
