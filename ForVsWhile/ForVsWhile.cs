using System;

namespace Vsite.CSharp.KontrolaToka
{
    class ForVsWhile
    {
        public static void PetljaFor(int n)
        {
            // :070 Napisati petlju for koja će ispisati brojeve od 0 do (uključivo) n
            for (int i = 0; i <= n; i++)

            {
                Console.WriteLine(i);
            }
        }

        public static void PetljaWhile(int n)
        { int i = 0;
            // :071 Napisati petlju while koja će ispisati brojeve od 0 do (uključivo) n
            while (i<=n)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void Main(string[] args)
        {
            PetljaFor(10);

            PetljaWhile(10);


            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        // :072 Pokrenuti program te provjeriti ispise

        // :073 Programom ILDasm (Program Files (x86)\Microsoft SDKs\Windows\vNN.N\bin\NETFX N.N Tools\ildasm.exe) usporediti međukod metoda PetljaFor i PetljaWhile

        // :074 Pokrenuti testove i projeriti prolaze li oba testa u grupi TestForVsWhile
    }
}
