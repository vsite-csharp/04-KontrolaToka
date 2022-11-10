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
        public void PoloziGodinu()
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
            ISpisiGeneralije(o);
            var s = new Student("Iva", 3);
            ISpisiGeneralije(s);
            s.PoloziGodinu();
            s.PoloziGodinu();
            ISpisiGeneralije(s);


        }

        private static void ISpisiGeneralije(Osoba o)
        {
            switch (o)
            {
                case Student s when s.Godina > 4:
                    Console.WriteLine($"Student: {s.Ime}, diplomirao");
                    break;
                case Student s when s.Godina == 1:
                    Console.WriteLine($"Student: {s.Ime}, brucoš");
                    break;
                case Student s:
                    Console.WriteLine($"Student: {s.Ime}, {s.Godina}. godina");
                    break;
                case Osoba:
                    Console.WriteLine($"Osoba: {o.Ime}");
                    break;
                default:
                    break;
            }
            Console.WriteLine($"Osoba: {o.Ime}");
        }
    }
}

