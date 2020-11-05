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

            // Ispisati vrijednosti lokalne varijable a
            Console.WriteLine(a);

            //  Ispisati vrijednost člana klase a
            Console.WriteLine(this.a);
            
            {
                //  Definirati novu varijablu a unutar ovog bloka i ispisati njenu vrijednost
                //double a = 3.14;
                //ne dozvoljava se da se deklarira ista varijabla
                //Console.WriteLine(a);
            }
            //  Pokrenuti testove i provjeriti je li prošao test u grupi TestDosegaImena

        }

        string a = "Član klase";
    }
}
