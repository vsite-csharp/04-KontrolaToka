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

		public void PoloziGodinu()
		{
			++Godina;
		}

		public Student(string ime, int godina) : base(ime)
		{
			Godina = godina;
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			var o = new Osoba("Pero");
			IspisiGeneralije(o);
            var s = new Student("Iva", 3);
            IspisiGeneralije(s);
			s.PoloziGodinu();
			s.PoloziGodinu();
			IspisiGeneralije(s);
        }

		private static void IspisiGeneralije(Osoba o)
		{
			switch (o)
			{
                case Student s when s.Godina > 4:
                    Console.WriteLine($"Student: {s.Ime}, diplomirao");
                    break;
                case Student s when s.Godina == 1:
                    Console.WriteLine($"Student: {s.Ime}, brucos");
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
			
		}
	}
}