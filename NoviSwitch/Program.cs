using System.Buffers;

namespace NoviSwitch
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
        public Student(string ime, int godina) : base(ime)
        {
            Godina = godina;
        }

        public void PoložiGodinu()
        {
            ++Godina;
        }

        public int Godina { get; private set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba o = new Osoba("Pero");
            IspišiOsobu(o);
            Student s = new Student("Iva", 3);
            IspišiOsobu(s);
            s.PoložiGodinu();
            s.PoložiGodinu();
            IspišiOsobu(s);
        }

        private static void IspišiOsobu(Osoba o)
        {
            switch (o)
            {
                case Student s when s.Godina > 4:
                    Console.WriteLine($"Student: {o.Ime} je diplomirao");
                    break;
                case Student s when s.Godina == 1:
                    Console.WriteLine($"Student: {o.Ime}, {s.Godina}. brucoš");
                    break;
                case Osoba o1:
                    Console.WriteLine($"Osoba: {o1.Ime}");
                    break;
            }
        }
    }
}