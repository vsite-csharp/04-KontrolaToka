using System;

namespace Vsite.CSharp.KontrolaToka
{
    class NulStapajućiOperator
    {
        public static void IspišiString(object obj)
        {
            // 040 Korištenjem Nul-stapajućeg (null-coalescing) operatora ?? ispisati sadržaj objekta ako je različit od null, inače ispisati "Nedefiniran"
            // null-coalescing operator je specifičan za CSH - on če vratiti objekt ako je objekt različit od null, u protivnom će vratiti neku drugu vrijednost

            // Console.WriteLine( obj != null ? obj : "Nedefiniran");
            Console.WriteLine(obj ?? "Nedefiniran"); // ovo su identične operacije
        }

        // 041 Pokrenuti testove i provjeriti prolaze li sva 4 testa iz grupe TestNulStapajućegOperatora

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
