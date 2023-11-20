namespace Vsite.CSharp.KontrolaToka
{
    static class NaredbeBreakContinue
    {
        public static int ZbrojiDoNSveKojiSuDjeljiviSaD(int n, int d)
        {
            int zbroj = 0;
            for (int i = 1; i <= n; ++i)
            {
                // :100 Ako i nije djeljiv s d, ne dodaje se (tj. treba se vratiti na početak petlje)
                if(i % d != 0) 
                {
                    continue;
                }
                zbroj += i;
            }
            return zbroj;
        }

        public static int ZbrojiDoNSveKojiSuDjeljiviSaDAliSamoDoPrvogDjeljivogSaD2(int n, int d, int d2)
        {
            int zbroj = 0;
            for (int i = 1; i <= n; ++i)
            {
                // :101 Ako i nije djeljiv s d, ne dodaje se (tj. treba se vratiti na početak petlje)
                if (i % d != 0)
                {
                    continue;
                }

                // :102 Ako je i djeljiv sa d2, tada treba prekinuti petlju
                else if (i % d2 == 0)
                {
                    break;
                }

                zbroj += i;
            }
            return zbroj;
        }

        // :103 Pokrenuti program i provjeriti ispise

        static void Main(string[] args)
        {
            Console.WriteLine(ZbrojiDoNSveKojiSuDjeljiviSaD(10, 2)); // trebalo bi ispisati 20
            Console.WriteLine(ZbrojiDoNSveKojiSuDjeljiviSaD(10, 3)); // trebalo bi ispisati 18
            Console.WriteLine(ZbrojiDoNSveKojiSuDjeljiviSaD(10, 5)); // trebalo bi ispisati 15

            Console.WriteLine(ZbrojiDoNSveKojiSuDjeljiviSaDAliSamoDoPrvogDjeljivogSaD2(10, 2, 4)); // trebalo bi ispisati 2
            Console.WriteLine(ZbrojiDoNSveKojiSuDjeljiviSaDAliSamoDoPrvogDjeljivogSaD2(10, 3, 8)); // trebalo bi ispisati 18

            Console.WriteLine("GOTOVO!!!");
        }
        // :104 Pokrenuti testove i provjeriti prolaze li svi testovi u grupi TestNaredbeBreakContinue
    }
}
