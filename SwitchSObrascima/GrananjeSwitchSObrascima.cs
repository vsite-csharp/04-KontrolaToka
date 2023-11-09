using System.Text;

namespace Vsite.CSharp.KontrolaToka
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

    static class GrananjeSwitchSObrascima
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Osoba o = new Osoba("Pero");
            IspišiOsobu(o);
            
            Student s = new Student("Janko", 1);
            IspišiOsobu(s);
            
            IspišiStudenta(s);
            s.PoložiGodinu();
            IspišiStudenta(s);
            s.PoložiGodinu();
            IspišiStudenta(s);
            s.PoložiGodinu();
            IspišiStudenta(s);
            s.PoložiGodinu();
            IspišiStudenta(s);

            IspišiOsobu(s);
        }

        public static void IspišiStudenta(Student s)
        {
            switch (s.Godina)
            {
                // :070 Dodati case za studenta 1. godine koji će ispisati $"{s.Ime} je brucoš". Pokrenuti program i provjeriti ispis.
                case 1:
                    Console.WriteLine($"{s.Ime} je brucoš");
                    break;

                // TODO:071 Dodati case za studente do 3. godine koji će ispisati $"{s.Ime} je student {s.Godina}. godine prediplomskog studija". Pokrenuti program i provjeriti ispis.
                case  < 3:
                    Console.WriteLine($"{s.Ime} je student {s.Godina}. godine prediplomskog studija");
                    break;

                // TODO:072 Dodati case za studente više od 3. godine koji će ispisati $"{s.Ime} je student {s.Godina - 3}. godine diplomskog studija". Pokrenuti program i provjeriti ispis.
                case > 3:
                    Console.WriteLine($"{s.Ime} je student {s.Godina - 3}. godine diplomskog studija");
                    break;
            }
        }

        public static void IspišiOsobu(Osoba o)
        {
            switch (o)
            {
                case Student s when s.Godina>4:
                    Console.WriteLine($"Student: {o.Ime}, {s.Godina}. godina");
                    break;
                case Student s:
                    Console.WriteLine($"Student: {o.Ime}, {s.Godina}. godina");
                    break;
                // TODO:073 Dodati case za objekt tipa Osoba koji će ispisati $"Osoba: {o.Ime}". Pokrenuti program i provjeriti ispis.
                case Osoba:
                    Console.WriteLine($"Osoba: {o.Ime}");
                    break;
                // TODO:074 Dodati case za objekt tipa Student koji koji će ispisati $"Student: {o.Ime}, {s.Godina}. godina". Pokrenuti program i provjeriti ispis.
               

                    // TODO:075 Dodati case za objekt tipa Student koji je na godini većoj od 4 koji će ispisati $"Student: {o.Ime} je diplomirao". Pokrenuti program i provjeriti ispis.

            }
        }
    }
}