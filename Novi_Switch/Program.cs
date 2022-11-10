namespace Novi_Switch
{
    class Osoba
    {
        public Osoba(string ime)
        {
            Ime = ime;
        }
        public readonly string Ime;
    }

    class Student : Osoba { 
        
        public Student(string ime, int godina) : base(ime)
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
            IspisiGeneralije(o);
            var s = new Student("Iva", 3);
            IspisiGeneralije(s);
            s.PoložiGodinu();
            s.PoložiGodinu();
            IspisiGeneralije(s);
        }
        private static void IspisiGeneralije(Osoba o)
        {
            switch (o)
            {
                case Student s when s.Godina > 4:
                    Console.WriteLine($"Student {s.Ime}, diplomiralo");
                    break;
                case Student s when s.Godina == 1:
                    Console.WriteLine($"Student {s.Ime}, brucoš");
                    break;
                case Student s:
                    Console.WriteLine($"Student {s.Ime}, {s.Godina}. godina");
                    break;


                case Osoba:
                    Console.WriteLine($"{o.Ime}");
                    break;
                
            }

        }
    }
}