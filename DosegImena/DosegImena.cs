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
        }

        public void IspišiAove()
        {
            string a = "Lokalna varijabla";

            // :000 Ispisati vrijednosti lokalne varijable a
            Console.WriteLine(a);
            // TODO:001 Ispisati vrijednost člana klase a
            Console.WriteLine(this.a);

            {
                // TODO:002 Definirati novu varijablu a unutar ovog bloka i ispisati njenu vrijednost
                //int a = 9;
            }
            // TODO:003 Pokrenuti testove i provjeriti je li prošao test u grupi TestDosegaImena
        }

        readonly string a = "Član klase";
    }
}
