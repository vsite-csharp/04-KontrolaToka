using System;

namespace Vsite.CSharp.KontrolaToka
{
    static class IspišiParnost
    {
        public static void UvjetnimPridruživanjem(int broj)
        {
            string odgovor = "neparan";

            _ = (broj % 2 == 0) ? odgovor = "paran" : odgovor;

            Console.WriteLine("Broj {0} je {1}", broj, odgovor);
        }

        public static void GrananjemIf(int broj)
        {
            string odgovor = "neparan";
            if (broj % 2 == 0)
            {
                odgovor = "paran";
            }
            else
            {
                odgovor = "neparan";
            }
            Console.WriteLine("Broj {0} je {1}", broj, odgovor);
        }
    }
}
