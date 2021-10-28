﻿using System;

namespace Vsite.CSharp.KontrolaToka
{
    class UsporedbeDecimalnihBrojeva
    {
        static void Main(string[] args)
        {
            double tri = 3.0;

            // Provjeriti što će ispisati donje usporedbe.
            if (JednakiSu(1.0, 1.00001))
                Console.WriteLine("1.0 je jednako 1.00001");
            else
                Console.WriteLine("1.0 nije jednako 1.00001!");

            if (JednakiSu(-1e-25, -1.00001e-25))
                Console.WriteLine("-1e-25 je jednako -1.00001e-25");
            else
                Console.WriteLine("-1e-25 nije jednako -1.00001e-25!");

            if (JednakiSu(-1e123, -1.00001e123))
                Console.WriteLine("-1e123 je jednako -1.00001e123");
            else
                Console.WriteLine("-1e-123 nije jednako -1.00001e123!");

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

        //Promijeniti metodu JednakiSu tako da se dobije očekivani rezultat
        public static bool JednakiSu(double broj1, double broj2)
        {
            if(Math.Abs(broj1) < 1e-20)
                return Math.Abs(broj1 - broj2) * 1e30 < 1e-15;

            return Math.Abs(broj1 - broj2) < 1e-15;
        }

        // Pokrenuti testove i provjeriti prolaze li 2 testa iz grupe TestUsporedbeDecimalnihBrojeva
    }
}
