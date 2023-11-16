namespace Vsite.CSharp.KontrolaToka
{
    static class PetljeWhileDoWhile
    {
        public static int BrojBacanjaDoBačeneŠestice()
        {
            Random generatorSlučajnih = new Random(); // generator slučajnih brojeva
            int brojBacanja = 0;
            int bačeniBroj = 0;

            // 090 Napisati petlju koja ispisuje rezultat bacanja sve dok ne padne na 6
            do
            {
                ++brojBacanja;
                bačeniBroj = generatorSlučajnih.Next(1, 7); // generira slučajni broj između 1 i 6
                Console.WriteLine($"{brojBacanja}. pokušaj: {bačeniBroj}");
            } while (bačeniBroj != 6);

            return brojBacanja;
        }

        public static int BacajDokNeProđe12Polja(int brojPređenihPolja)
        {
            Random generatorSlučajnih = new Random(); // generator slučajnih brojeva

            // 091 Napisati petlju koja se ponavlja sve dok brojPređenihPolja ne postane jednak ili veći od 12
            while (brojPređenihPolja < 12)
            {
                int bačeniBroj = generatorSlučajnih.Next(1, 7); // generira slučajni broj između 1 i 6
                Console.WriteLine($"Bacanje: {bačeniBroj}");
                brojPređenihPolja += bačeniBroj;
                Console.WriteLine($"Ukupno: {brojPređenihPolja}");
            };

            return brojPređenihPolja;
        }

        // 092 Pokrenuti program nekoliko puta i provjeriti ispise
        static void Main()
        {

            int brojPređenihPolja = BrojBacanjaDoBačeneŠestice();

            brojPređenihPolja = BacajDokNeProđe12Polja(brojPređenihPolja);
            Console.WriteLine($"Zbroj = {brojPređenihPolja}");

            Console.WriteLine("GOTOVO!!!");
        }

        // 093 Pokrenuti testove i provjeriti prolaze li testovi u grupi TestPetljeWhileDoWhile
    }
}
