namespace Vsite.CSharp.KontrolaToka
{
    static class Yield
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kvadrati brojeva:");
            // :120 Postaviti prekidnu točku (breakpoint) na 'in' u donjoj petlji foreach, pokrenuti program i nakon svakog prekida napraviti 'Step Into' (F11) i pratiti izvođenje metode DajKvadrat
            foreach (var kvadrat in DajKvadrate())
                Console.WriteLine(kvadrat);

            Console.WriteLine();
            Console.WriteLine("Fibonaccijev niz preko liste:");
            var niz1 = FibonacciList();
            foreach (var broj in niz1)
                Console.WriteLine(broj);

            Console.WriteLine();
            Console.WriteLine("Fibonaccijev niz pomoću yielda:");
            var niz2 = FibonacciIEnumerable();
            foreach (var broj in niz2)
                Console.WriteLine(broj);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey();
        }

        static IEnumerable<int> DajKvadrate()
        {
            yield return 0;
            yield return 1;
            yield return 4;
            yield return 9;
            yield return 16;
        }

        public static IList<int> FibonacciList()
        {
            List<int> rezultat = new List<int>();
            rezultat.Add(0);
            rezultat.Add(1);

            int prethodni = 0;
            int trenutni = 1;
            while (prethodni < int.MaxValue)
            {
                try
                {

                    // :121 Promijenite petlju tako da se unutar petlje provjerava je li donja operacija bacila OverflowException i u tom slučaju prekida petlju
                    // U postavkama projekta uključiti opciju za provjeru numeričkog preljeva i pokrenuti program.
                    int zbroj = prethodni + trenutni;
                    prethodni = trenutni;
                    trenutni = zbroj;
                    rezultat.Add(trenutni);
                } 
                catch(Exception e) 
                { 
                    if (e.GetType() == typeof(OverflowException)) break; 
                }
            }
            return rezultat;
        }

        // :122 Implementirajte donju metodu korištenjem koda gornje metode FibonacciList
        public static IEnumerable<int> FibonacciIEnumerable()
        {
            foreach(int i in FibonacciList()) { yield return i; }

        }

        // :123 Pokrenuti program i provjeriti ispise

        // :124 Pokrenuti testove i provjeriti prolaze li svi testovi iz grupe TestYield
    }
}
