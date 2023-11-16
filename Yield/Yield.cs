namespace Vsite.CSharp.KontrolaToka
{
    static class Yield
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kvadrati brojeva:");
            // 130 Postaviti prekidnu točku (breakpoint) na 'in' u donjoj petlji foreach, pokrenuti program i nakon svakog prekida napraviti 'Step Into' (F11) i pratiti izvođenje metode DajKvadrat
            foreach (var kvadrat in DajKvadrate())
            {
                Console.WriteLine(kvadrat);
            }

            Console.WriteLine();
            Console.WriteLine("Fibonaccijev niz preko liste:");
            var niz1 = FibonacciList();
            foreach (var broj in niz1)
            {
                Console.WriteLine(broj);
            }

            Console.WriteLine();
            Console.WriteLine("Fibonaccijev niz pomoću yielda:");
            var niz2 = FibonacciIEnumerable();
            foreach (var broj in niz2)
            {
                Console.WriteLine(broj);
            }

            Console.WriteLine("GOTOVO!!!");
        }

        static IEnumerable<int> DajKvadrate()
        {
            yield return 0;
            yield return 1;
            yield return 4;
            yield return 9;
            yield return 16;
        }
        //ovo zanemarite isprobavala sam nesto 
        //static IEnumerable<int> DajKvadrate()
        //{
        //    int i = 0;
        //    while(true)
        //    {
        //        try
        //        {
        //            i++;
        //        }
        //        catch(OverflowException e)
        //        {
        //            Console.WriteLine(e.Message);
        //            yield break;
        //        }
        //        yield return (i * i);
        //    }
        //}


        public static IList<int> FibonacciList()
        {
            List<int> rezultat = new List<int>();
            rezultat.Add(0);
            rezultat.Add(1);

            int prethodni = 0;
            int trenutni = 1;
            while (prethodni < int.MaxValue)
            {
                // 131 Promijenite petlju tako da se unutar petlje provjerava je li donja operacija bacila
                // OverflowException i u tom slučaju prekida petlju
                // U postavkama projekta uključiti opciju za provjeru numeričkog preljeva i pokrenuti program.
                try
                {
                    int zbroj = prethodni + trenutni;
                    prethodni = trenutni;
                    trenutni = zbroj;
                    rezultat.Add(trenutni);
                }
                catch (OverflowException e){
                    Console.WriteLine(e.Message);
                    break;
                }
            }
            return rezultat;
        }

        // 132 Implementirajte donju metodu korištenjem koda gornje metode FibonacciList
        public static IEnumerable<int> FibonacciIEnumerable()
        {
            yield return 0;
            yield return 1;

            int prethodni = 0;
            int trenutni = 1;
            while (prethodni < int.MaxValue)
            {
                // 131 Promijenite petlju tako da se unutar petlje provjerava je li donja operacija bacila
                // OverflowException i u tom slučaju prekida petlju
                // U postavkama projekta uključiti opciju za provjeru numeričkog preljeva i pokrenuti program.
                try
                {
                    int zbroj = prethodni + trenutni;
                    prethodni = trenutni;
                    trenutni = zbroj;
                    
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                    yield break;
                }
                yield return trenutni;
            }
          
        }

        // 133 Pokrenuti program i provjeriti ispise

        // 134 Pokrenuti testove i provjeriti prolaze li svi testovi iz grupe TestYield
    }
}
