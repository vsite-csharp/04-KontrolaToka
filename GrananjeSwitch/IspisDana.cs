namespace Vsite.CSharp.KontrolaToka
{
    static class IspisDana
    {
        public static string ImeDana(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                case DayOfWeek.Monday:
                    return "Ponedjeljak";
                case DayOfWeek.Tuesday:
                    return "Utorak";
                case DayOfWeek.Wednesday:
                    return "Srijeda";
                case DayOfWeek.Thursday:
                    return "Četvrtak";
                case DayOfWeek.Friday:
                    return "Petak";
                case DayOfWeek.Saturday:
                    return "Subota";
                case DayOfWeek.Sunday:
                    return "Nedjelja";
                // TODO:060 Napisati grane case za svaki dan u tjednu tako da vraćaju "ponedjeljak" za DayOfWeek.Monday, "utorak" za DayOfWeek.Tuesday itd.

                // TODO:061 Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
                default:
                    return "";
                    throw new NotImplementedException();
            }
        }

        public static string RadniNeradni(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                // TODO:062 Napisati grane case tako da za svaki radni dan u tjednu vraća "radni dan", a za subotu i nedjelju vraća "vikend"

                // TODO:063 Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
                default:
                    throw new NotImplementedException();
            }
        }

        // TODO:064 Pokrenuti program i provjeriti ispravnost ispisa
        
        // TODO:065 Pokrenuti testove i provjeriti prolaze li svi testovi iz grupe TestGrananjaSwitch
    }
}
