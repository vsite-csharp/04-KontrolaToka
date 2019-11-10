using System;

namespace Vsite.CSharp.KontrolaToka
{
    class NulStapajućiOperator
    {
        public static void IspišiString(object obj)
        {
            obj = obj ?? "Nedefiniran";
            Console.WriteLine(obj);

        }

        static void Main(string[] args)
        {
            string ime = "Pero";
            IspišiString(ime); // trebalo bi ispisati "Pero"
            ime = null;
            IspišiString(ime); // trebalo bi ispisati "Nedefiniran"

            double? broj = 5.3;
            IspišiString(broj); // trebalo bi ispisati "5,3"
            broj = null;
            IspišiString(broj); // trebalo bi ispisati "Nedefiniran"

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
