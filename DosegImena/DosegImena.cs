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


            Console.WriteLine(a);
            Console.WriteLine(this.a);
            {
                // TODO:012 Definirati novu varijablu a unutar ovog bloka i ispisati njenu vrijednost
                //int a = 5;
            }
        }

        string a = "Član klase";
    }
}
