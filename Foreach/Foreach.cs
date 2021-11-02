using System;
using System.Collections.Generic;
using System.Collections;

namespace Vsite.CSharp.KontrolaToka
{
    public class Foreach
    {
        public static void Ispiši(IEnumerable kolekcija)
        {
            // 100 Napisati foreach petlju tako da ispisuje sve članove kolekcije
            foreach (var član in kolekcija)
            {
                Console.WriteLine(član);
            }

        }

        // 101 Pokrenuti program i provjeriti ispise

        public static void Main(string[] args)
        {
            string[] imena = new string[] { "Pero", "Janko", "Mijo" };
            Ispiši(imena);

            Queue<int> intovi = new Queue<int>(new int[] { 1, 5, 3, 11 });
            Ispiši(intovi);

            List<double> dablovi = new List<double> { 3.14, 4.15, 2.78 };
            Ispiši(dablovi);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
        // 102 Pokrenuti testove i provjeriti prolaze li oba testa u grupi TestForeach
    }
}
