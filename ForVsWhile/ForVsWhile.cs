﻿using System;

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
        {
            // :071 Napisati petlju while koja će ispisati brojeve od 0 do (uključivo) n
            int i = 0;

            while (i <= n)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void Main(string[] args)
        {
            PetljaFor(10);

            PetljaWhile(10);

            // :072 Prevesti program te programom ILDasm usporediti međukod gornjih metoda

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        // :073 Pokrenuti testove i projeriti prolaze li oba testa u grupi TestForVsWhile
        // Prolaze
    }
}
