﻿using System;

namespace Vsite.CSharp.KontrolaToka
{
    class DosegImena
    {
        static void Main(string[] args)
        {
            DosegImena p = new DosegImena();
            p.IspišiAove();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        public void IspišiAove()
        {
            string a = "Lokalna varijabla";

            // TODO:010 Ispisati vrijednosti lokalne varijable a

            Console.WriteLine(a);

            // TODO:011 Ispisati vrijednost člana klase a

            Console.WriteLine(this.a);


            {
                // TODO:012 Definirati novu varijablu a unutar ovog bloka i ispisati njenu vrijednost
               // int a = 5;
            }
        }

        string a = "Član klase";
    }
}
