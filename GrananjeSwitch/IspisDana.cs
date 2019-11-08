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
                case DayOfWeek.Tuesday:
                    return "radni dan";
                case DayOfWeek.Wednesday:
                    return "radni dan";
                case DayOfWeek.Thursday:
                    return "radni dan";
                case DayOfWeek.Friday:
                    return "radni dan";
                case DayOfWeek.Saturday:
                    return "vikend";
                case DayOfWeek.Sunday:
                    return "vikend";

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
