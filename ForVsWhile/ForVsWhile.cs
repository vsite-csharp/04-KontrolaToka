﻿namespace Vsite.CSharp.KontrolaToka
{
    static class ForVsWhile
    {
        public static void PetljaFor(int n)
        {
            // TODO:080 Napisati petlju for koja će ispisati brojeve od 0 do (uključivo) n
        }

        public static void PetljaWhile(int n)
        {
            // TODO:081 Napisati petlju while koja će ispisati brojeve od 0 do (uključivo) n
        }

        static void Main(string[] args)
        {
            PetljaFor(10);

            PetljaWhile(10);


            Console.WriteLine("GOTOVO!!!");
        }

        // TODO:082 Pokrenuti program te provjeriti ispise

        // TODO:083 Programom ILDasm (Program Files (x86)\Microsoft SDKs\Windows\vNN.N\bin\NETFX N.N Tools\ildasm.exe) usporediti međukod metoda PetljaFor i PetljaWhile

        // TODO:084 Pokrenuti testove i projeriti prolaze li oba testa u grupi TestForVsWhile
    }
}
