﻿using System;
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
                // Napisati grane case za svaki dan u tjednu tako da vraćaju "ponedjeljak" za DayOfWeek.Monday, "utorak" za DayOfWeek.Tuesday itd.
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
                    

                // Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
                default:
                    throw new ArgumentOutOfRangeException();

                    
            }
        }

        public static string RadniNeradni(DayOfWeek danUTjednu)
        {
            switch (danUTjednu)
            {
                //  Napisati grane case tako da za svaki radni dan u tjednu vraća "radni dan", a za subotu i nedjelju vraća "vikend"
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
                    return "Vikend";

                case DayOfWeek.Sunday:
                    return "Vikend";
                // Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        // Pokrenuti testove i provjeriti prolaze li svi testovi iz grupe TestGrananjaSwitch
    }
}
