using System;

namespace Vsite.CSharp.KontrolaToka
{
    static class IspišiParnost
    {
        public static void UvjetnimPridruživanjem(int broj)
        {
            //DZ
            // TODO:030 Napisati uvjetno pridruživanje ?: koje će ovisno o dijeljivosti broja varijabli odgovor dodijeliti vrijednost "paran" ili "neparan"
            string odgovor = "neparan";

            Console.WriteLine("Broj {0} je {1}", broj, odgovor);
        }

        public static void GrananjemIf(int broj)
        {
            // TODO:031 Korištenjem grananja if dodijeliti varijabli odgovor vrijednost "paran" ili "neparan" ovisno o djeljivosti zadanog broja
            string odgovor = "neparan";

            Console.WriteLine("Broj {0} je {1}", broj, odgovor);
        }

        // TODO:032 Pokrenuti testove i provjeriti prolaze li oba testa iz grupe TestUvjetnogPridruživanja
    }
}
