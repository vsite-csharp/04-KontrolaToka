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
                {
                    return "Monday";
                }
                case DayOfWeek.Tuesday:
                {
                    return "Tuesday";
                }
                case DayOfWeek.Wednesday:
                {
                    return "Wednesday";
                }
                case DayOfWeek.Thursday:
                {
                    return "Thursday";
                }
                case DayOfWeek.Friday:
                {
                    return "Friday";
                }
                case DayOfWeek.Saturday:
                {
                    return "Saturday";
                }
                case DayOfWeek.Sunday:
                {
                    return "Sunday";
                }
                default:
                    throw new ArgumentOutOfRangeException("Value is not good");
            }
        }

        public static string RadniNeradni(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    return "vikend";
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    return "radni dan";
                default:
                    throw new ArgumentOutOfRangeException("Value is not good");
            }
        }
    }
}
