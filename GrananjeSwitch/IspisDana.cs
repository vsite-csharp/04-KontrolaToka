namespace Vsite.CSharp.KontrolaToka
{
    static class IspisDana
    {
        public static string ImeDana(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                // TODO:060 Napisati grane case za svaki dan u tjednu tako da vraćaju "ponedjeljak" za DayOfWeek.Monday, "utorak" za DayOfWeek.Tuesday itd.
                case DayOfWeek.Monday:
                    return "ponedjeljak";
                case DayOfWeek.Tuesday:
                    return "utorak";
                case DayOfWeek.Wednesday:
                    return "srijeda";
                case DayOfWeek.Thursday:
                    return "četvrtak";
                case DayOfWeek.Friday:
                    return "petak";
                case DayOfWeek.Saturday:
                    return "subota";
                case DayOfWeek.Sunday:
                    return "nedjelja";
                // TODO:061 Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static string RadniNeradni(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                // TODO:062 Napisati grane case tako da za svaki radni dan u tjednu vraća "radni dan", a za subotu i nedjelju vraća "vikend"
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    return "radni dan";
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    return "vikend";
                // TODO:063 Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        // TODO:064 Pokrenuti program i provjeriti ispravnost ispisa
        
        // TODO:065 Pokrenuti testove i provjeriti prolaze li svi testovi iz grupe TestGrananjaSwitch
    }
}
