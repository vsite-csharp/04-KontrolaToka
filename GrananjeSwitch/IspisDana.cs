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
                    return "Ponedjeljak";
                case DayOfWeek.Tuesday:
                    return "Utorak";
                case DayOfWeek.Wednesday:
                    return "Srijeda";
                case DayOfWeek.Thursday:
                    return "Četvrtak";
                case DayOfWeek.Friday:
                    return "Petak";
                case DayOfWeek.Sunday:
                    return "Subota";
                case DayOfWeek.Saturday:
                    return "Nedjelja";     
                default:
                    throw new ArgumentOutOfRangeException();
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
                    return "Dan u tjednu";
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    return "Vikend ayyyy";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
