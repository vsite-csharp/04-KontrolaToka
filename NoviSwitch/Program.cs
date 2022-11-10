namespace NoviSwitch
{
    class Osoba
    {
        public readonly string Ime;
        public Osoba(string ime)
        {
            Ime = ime;
        }

    }

    class Student : Osoba
    {
        public int Godina;
        public Student(string ime, int godina) : base(ime)
        {
            Godina = godina;
        }
        
        public void PoložiGodinu()
        {
            ++Godina;
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            var o = new Osoba("Grga");
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
                    Console.WriteLine($"Student: {s.Ime}, diplomirao");
                    break;
                case Student s when s.Godina == 1:
                    Console.WriteLine($"Student: {s.Ime}, {s.Godina}");
                    break;
                case Student s:
                    Console.WriteLine($"Student: {s.Ime}, {s.Godina}");
                    break;
                case Osoba:
                    Console.WriteLine($"Osoba: {o.Ime}");
                    break;
            }
        }
    }
}