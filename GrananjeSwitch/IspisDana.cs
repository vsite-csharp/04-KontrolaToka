namespace Vsite.CSharp.KontrolaToka
{
    static class IspisDana
    {
        public static string ImeDana(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                case DayOfWeek.Monday:
                    return "Ponedeljak";
				case DayOfWeek.Tuesday:
					return "Utorak";
				case DayOfWeek.Wednesday:
					return "Srijeda";
				case DayOfWeek.Thursday:
					return "Cetvrtak";
				case DayOfWeek.Friday:
					return "Petak";
				case DayOfWeek.Sunday:
					return "Subota";
				case DayOfWeek.Saturday:
					return "Nedelja";

				// 060 Napisati grane case za svaki dan u tjednu tako da vraćaju "ponedjeljak" za DayOfWeek.Monday, "utorak" za DayOfWeek.Tuesday itd.

				// 061 Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
				default:
                    throw new NotImplementedException();
					// throw new ArgumentOutOfRangeException();
			}
		}

        public static string RadniNeradni(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    return "radni dan";
				// 062 Napisati grane case tako da za svaki radni dan u tjednu vraća "radni dan", a za subotu i nedjelju vraća "vikend"
				case DayOfWeek.Saturday:
				case DayOfWeek.Sunday:
                    return "vieknd";
				// 063 Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
				default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        // 064 Pokrenuti program i provjeriti ispravnost ispisa
        
        // 065 Pokrenuti testove i provjeriti prolaze li svi testovi iz grupe TestGrananjaSwitch
    }
}
