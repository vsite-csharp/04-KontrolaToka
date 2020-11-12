using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp.KontrolaToka
{
    class MetodeProširenja
    {
        static void Main(string[] args)
        {
            string[] riječi = new string[] { "Franjo", "Ivana", "Dora", "Mirko" };
            Console.WriteLine("Niz riječi:");
            Foreach.Ispiši(riječi);
            string ime = "Ivana";
            Console.WriteLine($"Sadrži riječ '{ime}': {Pretraga.Sadrži(riječi, ime)}");
            ime = "Pero";
            Console.WriteLine($"Sadrži riječ '{ime}': {Pretraga.Sadrži(riječi, ime)}");

            Console.WriteLine();
            Console.WriteLine("Brojevi:");
            int[] brojevi = new int[] { 1, 2, 3, 4, 5 };
            Foreach.Ispiši(brojevi);
            Console.WriteLine($"Njihov zbroj je: {Pretraga.Zbroj(brojevi)}");

            Console.WriteLine();
            Console.WriteLine("Iz niza riječi:");
            riječi = new string[] { "more", "sunce", "rijeka", "mjesec", "potok", "barka" };
            Foreach.Ispiši(riječi);

            string granična = "student";
            Console.WriteLine($"sljedeće riječi su abecedno iza riječi '{granična}':");
            foreach (string riječ in Pretraga.NađiSveIza(riječi, granična))
                Console.WriteLine(riječ);

            granična = "mater";
            Console.WriteLine($"sljedeće riječi su abecedno iza riječi '{granična}':");
            foreach (string riječ in Pretraga.NađiSveIza(riječi, granična))
                Console.WriteLine(riječ);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
