using System;

namespace Vsite.CSharp.KontrolaToka
{
    static class IspišiParnost
    {
        public static void UvjetnimPridruživanjem(int broj)
        {
            // Napisati uvjetno pridruživanje ?: koje će ovisno o dijeljivosti broja varijabli odgovor dodijeliti vrijednost "paran" ili "neparan"
            string odgovor = "neparan";
            odgovor = broj % 2 == 0 ? "paran" : odgovor;
            Console.WriteLine("Broj {0} je {1}", broj, odgovor);
        }

        public static void GrananjemIf(int broj)
        {
            // Korištenjem grananja if dodijeliti varijabli odgovor vrijednost "paran" ili "neparan" ovisno o djeljivosti zadanog broja
            string odgovor = "neparan";
            if (broj % 2 == 0)
            {
                odgovor = "paran";
                Console.WriteLine("Broj {0} je {1}", broj, odgovor);
            }
            else 
            { 
            Console.WriteLine("Broj {0} je {1}", broj, odgovor);
            }
        }

        // Pokrenuti program nekoliko puta i za različite unose provjeriti ispravnost koda
        // TODO:033 Pokrenuti testove i provjeriti prolaze li oba testa iz grupe TestUvjetnogPridruživanja
    }
}
