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
                // int a = 5; - compile error, inner scope cant have same variable name if that name exists outside. 
            }
        }

        string a = "Član klase";
    }
}
