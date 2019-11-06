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
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static string RadniNeradni(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                case DayOfWeek.Monday:
                    return "radni dan";
                    break;
                case DayOfWeek.Tuesday:
                    return "radni dan";
                    break;
                case DayOfWeek.Wednesday:
                    return "radni dan";
                    break;
                case DayOfWeek.Thursday:
                    return "radni dan";
                    break;
                case DayOfWeek.Friday:
                    return "radni dan";
                    break;
                case DayOfWeek.Saturday:
                    return "vikend";
                    break;
                case DayOfWeek.Sunday:
                    return "vikend";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
