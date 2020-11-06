using System;

namespace Vsite.CSharp.KontrolaToka
{
    static class IspišiParnost
    {
        public static void UvjetnimPridruživanjem(int broj)
        {
            // Napisati uvjetno pridruživanje ?: koje će ovisno o dijeljivosti broja varijabli odgovor dodijeliti vrijednost "paran" ili "neparan"
            string odgovor = broj % 2 == 0 ? "paran" : "neparan";

            Console.WriteLine("Broj {0} je {1}", broj, odgovor);
        }

        public static void GrananjemIf(int broj)
        {
            // Korištenjem grananja if dodijeliti varijabli odgovor vrijednost "paran" ili "neparan" ovisno o djeljivosti zadanog broja
            if (broj % 2 == 0)
            {
                string odgovor = "paran";
                Console.WriteLine("Broj {0} je {1}", broj, odgovor);
            }
            else
            {
                string odgovor = "neparan";
                Console.WriteLine("Broj {0} je {1}", broj, odgovor);
            }
        }

        // Pokrenuti testove i provjeriti prolaze li oba testa iz grupe TestUvjetnogPridruživanja
    }
}
