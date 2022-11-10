using System;

namespace Novi_switch
{
    class Osoba
    {
        public Osoba(string ime)
        {
            Ime = ime;
        }
        public readonly string Ime;
    }

    class Student : Osoba
    {
        public Student(string ime,int godina) : base(ime)
        {
            Godina = godina;
        }

        public void PoložiGodinu()
        {
            ++Godina;
        }

        public int Godina;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var o = new Osoba("Pero");
            IspišiGeneralije(o);
            var s = new Student("Iva", 3);
            IspišiGeneralije(s);
            s.PoložiGodinu();
            s.PoložiGodinu();
            IspišiGeneralije(s);
        }

        private static void IspišiGeneralije(Osoba o)
        {
            switch (o)
            {
                case Student s when s.Godina > 4:
                    Console.WriteLine($"Student: {o.Ime},diplomirao");
                    break;
                case Student s when s.Godina == 1:
                    Console.WriteLine($"Student: {o.Ime},brucoš");
                    break;
                case Student s:
                    Console.WriteLine($"Student: {o.Ime},{s.Godina}.godina");
                    break;
                //case Osoba :
                    Console.WriteLine($"Osoba: {o.Ime}");
                    break;
                

            }

        }
    }
}
