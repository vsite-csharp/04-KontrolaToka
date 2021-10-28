using System;

namespace Vsite.CSharp.KontrolaToka
{
    class UsporedbeDecimalnihBrojeva
    {
        static void Main(string[] args)
        {
            double tri = 3.0;

            // :020 Provjeriti što će ispisati donje dvije usporedbe te promijeniti metodu JednakiSu tako da se dobije očekivani rezultat
            // :021 Pokrenuti testove i provjeriti prolaze li 2 testa iz grupe TestUsporedbeDecimalnihBrojeva
            if (JednakiSu((1.0 - 1.0 / tri), (2.0 / tri)))
                Console.WriteLine("1 - 1/3 jednako je 2/3");
            else
                Console.WriteLine("1 - 1/3 nije jednako 2/3!");

            if (JednakiSu(tri * 0.1, 0.3))
                Console.WriteLine("3 * 0.1 je jednako 0.3");
            else
                Console.WriteLine("3 * 0.1 nije jednako 0.3!");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        public static bool JednakiSu(double broj1, double broj2)
        {
            if(broj1 == broj2)
            {
                return true;
            }
            double razlika = Math.Abs(broj1 - broj2);
            double manji = Math.Min(Math.Abs(broj1), Math.Abs(broj2));
            const double epsilon = double.Epsilon * double.MaxValue;

            return razlika / manji < epsilon;


            //return broj1 == broj2;
        }
    }
}
