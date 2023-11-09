namespace Vsite.CSharp.KontrolaToka
{
    static class IspisDana
    {
        public static string ImeDana(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                // :060 Napisati grane case za svaki dan u tjednu tako da vraćaju "ponedjeljak" za DayOfWeek.Monday, "utorak" za DayOfWeek.Tuesday itd.
                case DayOfWeek.Sunday: return "Nedjelja";
                case DayOfWeek.Monday: return "Ponedjeljak";
                case DayOfWeek.Tuesday: return "Utorak";
                case DayOfWeek.Wednesday: return "Srijeda";
                case DayOfWeek.Thursday: return "Četvrtak";
                case DayOfWeek.Friday: return "Petak";
                case DayOfWeek.Saturday: return "Subota";


                // :061 Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
                default:
                    throw new ArgumentOutOfRangeException(nameof(danUTjednu));
            }
        }

        public static string RadniNeradni(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                // :062 Napisati grane case tako da za svaki radni dan u tjednu vraća "radni dan", a za subotu i nedjelju vraća "vikend"
                case DayOfWeek.Sunday: return "vikend";
                case DayOfWeek.Saturday: return "vikend";
                case DayOfWeek: return "radni dan";
                // :063 Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
                default:
                    throw new ArgumentOutOfRangeException(nameof(danUTjednu));
            }
        }

        // :064 Pokrenuti program i provjeriti ispravnost ispisa
        
        // :065 Pokrenuti testove i provjeriti prolaze li svi testovi iz grupe TestGrananjaSwitch
    }
}
