using System;

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

            // TODO:000 Ispisati vrijednosti lokalne varijable a

            // TODO:001 Ispisati vrijednost člana klase a

            {
                // TODO:002 Definirati novu varijablu a unutar ovog bloka i ispisati njenu vrijednost

            }
            // TODO:003 Pokrenuti testove i provjeriti je li prošao test u grupi TestDosegaImena
        }

        string a = "Član klase";
    }
}
