using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.KontrolaToka
{
    static class IspisDana
    {
        public static string ImeDana(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                // :060 Napisati grane case za svaki dan u tjednu tako da vraćaju "ponedjeljak" za DayOfWeek.Monday, "utorak" za DayOfWeek.Tuesday itd.
                case DayOfWeek.Monday:
                    return "ponedjeljak";
                    break;
                case DayOfWeek.Tuesday:
                    return "utorak";
                    break;
                case DayOfWeek.Wednesday:
                    return "srijeda";
                    break;
                case DayOfWeek.Thursday:
                    return "četvrtak";
                    break;
                case DayOfWeek.Friday:
                    return "petak";
                    break;
                case DayOfWeek.Saturday:
                    return "subota";
                    break;
                case DayOfWeek.Sunday:
                    return "nedjelja";
                    break;
                // :061 Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
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
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    return "vikend";
                    break;
                // :063 Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        // :064 Pokrenuti program i provjeriti ispravnost ispisa
        
        // :065 Pokrenuti testove i provjeriti prolaze li svi testovi iz grupe TestGrananjaSwitch
    }
}
