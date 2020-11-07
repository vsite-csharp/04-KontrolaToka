using System;

namespace Vsite.CSharp.KontrolaToka
{
    static class IspišiParnost
    {
        public static void UvjetnimPridruživanjem(int broj)
        {
            // Napisati uvjetno pridruživanje ?: koje će ovisno o dijeljivosti broja varijabli odgovor dodijeliti vrijednost "paran" ili "neparan"
            string odgovor = "neparan";
            int parnost = broj % 2;
            int paran = 0;

            Console.WriteLine("Broj {0} je {1}", broj, parnost==paran ? odgovor = "paran" : odgovor);
        }

        public static void GrananjemIf(int broj)
        {
            // Korištenjem grananja if dodijeliti varijabli odgovor vrijednost "paran" ili "neparan" ovisno o djeljivosti zadanog broja
            string odgovor = "neparan";

            if(broj % 2 == 0)
            {
                odgovor = "paran";
                Console.WriteLine("Broj {0} je {1}", broj, odgovor);
            }
            else if (broj % 2 != 0)
                Console.WriteLine("Broj {0} je {1}", broj, odgovor);
            else
                Console.WriteLine("Pogrešan unos!!!");
        }

        // Pokrenuti testove i provjeriti prolaze li oba testa iz grupe TestUvjetnogPridruživanja
    }
}
