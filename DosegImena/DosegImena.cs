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

            Console.WriteLine(a);
            Console.WriteLine(this.a);
            {
                //string a = "ampadu";
                Console.WriteLine(a);
            }
        }

        string a = "Član klase";
    }
}
