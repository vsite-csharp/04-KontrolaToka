namespace Vsite.CSharp.KontrolaToka
{
    static class UsporedbeDecimalnihBrojeva
    {
        static void Main(string[] args)
        {
            double tri = 3.0;

            // 020 Provjeriti što će ispisati donje usporedbe.
            IspišiJesuLiJednaki(1.0, 1.0001);

            IspišiJesuLiJednaki(-1e-25, -1.00001e-25);

            IspišiJesuLiJednaki(-1e123, -1.00001e123);

            if (JednakiSu((1.0 - 1.0 / tri), (2.0 / tri)))
            {
                Console.WriteLine("1 - 1/3 jednako je 2/3");
            }
            else
            {
                Console.WriteLine("1 - 1/3 nije jednako 2/3!");
            }
            //IspišiJesuLiJednaki((1.0 - 1.0 / tri), (2.0 / tri));

            if (JednakiSu(tri * 0.1, 0.3))
            { 
                Console.WriteLine("3 * 0.1 je jednako 0.3");
            }
            else 
            { 
                Console.WriteLine("3 * 0.1 nije jednako 0.3!");
            }
            //IspišiJesuLiJednaki(tri * 0.1, 0.3);

            Console.WriteLine("GOTOVO!!!");
        }

        private static void IspišiJesuLiJednaki(double a, double b)
        {
            if (JednakiSu(a, b))
            {
                Console.WriteLine($"{a} je jednako {b}");
            }
            else
            {
                Console.WriteLine($"{a} nije jednako {b}!");
            }
        }

        //021 Promijeniti metodu JednakiSu tako da se dobije očekivani rezultat
        public static bool JednakiSu(double broj1, double broj2)
        {
            if (broj1 == broj2)
                return true;
           return Math.Abs(broj1 - broj2) / (Math.Abs(Math.Max(broj1, broj2))) < 1e-10;
        }

        // 022 Pokrenuti testove i provjeriti prolaze li 2 testa iz grupe TestUsporedbeDecimalnihBrojeva
    }
}
