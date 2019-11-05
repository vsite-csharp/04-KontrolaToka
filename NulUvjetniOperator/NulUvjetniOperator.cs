﻿using System;
using System.Globalization;
using System.IO;

namespace Vsite.CSharp.KontrolaToka
{
    class NulUvjetniOperator
    {
        public static string PozoviToString(object obj)
        {
            return obj?.ToString();
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            string ime = "Dinko";
            Console.WriteLine("Ispisujem string 'Dinko':");
            Console.WriteLine(PozoviToString(ime)); // trebalo bi ispisati "Dinko"

            ime = null;
            Console.WriteLine("Ispisujem null-string:");
            Console.WriteLine(PozoviToString(ime)); // trebalo bi ispisati prazan redak

            object obj = null;
            Console.WriteLine("Ispisujem null-object:");
            Console.WriteLine(PozoviToString(obj)); // trebalo bi ispisati prazan redak

            obj = new object();
            Console.WriteLine("Ispisujem object:");
            Console.WriteLine(PozoviToString(obj)); // trebalo bi ispisati "System.Object"

            CultureInfo ci = null;
            Console.WriteLine("Ispisujem null-CultureInfo:");
            Console.WriteLine(PozoviToString(ci)); // trebalo bi ispisati prazan redak

            ci = new CultureInfo(0x041A);
            Console.WriteLine("Ispisujem CultureInfo za hrvatski:");
            Console.WriteLine(PozoviToString(ci)); // trebalo bi ispisati "hr-HR"

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }
    }
}
