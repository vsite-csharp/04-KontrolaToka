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

            // 000 Ispisati vrijednosti lokalne varijable a
            Console.WriteLine(a);

            // kreira objekt a                        
            // ispisuje 
            // Lokalna varijabla
            // "GOTOVO!!!"

            // 001 Ispisati vrijednost člana klase a
            Console.WriteLine(this.a);  // this je pointer na instancu objekta
                                        // ispisuje član te klase
                                        // ispisuje:
                                        // "Član klase"

            {
                // 002 Definirati novu varijablu a unutar ovog bloka i ispisati njenu vrijednost
                // double a = 3.14; // CSH ne dozvoljava da unutar bloka definiramo istoimenu varijablu okolnog bloka
                                    // ovo CSH štiti korisnika od greške - ne dozvoljava

                // Console.WriteLine(a);
            }
            // 003 Pokrenuti testove i provjeriti je li prošao test u grupi TestDosegaImena
            // u Solution explorer -> Testovi ili izbornik Test (Ctrl-R A)

        }

        string a = "Član klase";
    }
}
