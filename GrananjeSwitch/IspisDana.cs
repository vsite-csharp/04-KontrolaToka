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
            String dt = danUTjednu.ToString();

            //switch (danUTjednu)
            switch (dt)
            {
                // 060 Napisati grane case za svaki dan u tjednu tako da vraćaju "ponedjeljak" za DayOfWeek.Monday, "utorak" za DayOfWeek.Tuesday itd.
                case "Monday":
                    return "ponedjeljak";
                    break;
                case "Tuesday":
                    return "utorak";
                    break;
                case "Wednesday":
                    return "srijeda";
                    break;
                case "Thursday":
                    return "četvrtak";
                    break;
                case "Friday":
                    return "petak";
                    break;
                case "Saturday":
                    return "subota";
                    break;
                case "Sunday":
                    return "nedjelja";
                    break;

                // 061 Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
                default:
                    
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static string RadniNeradni(DayOfWeek danUTjednu)
        {
            String dt = danUTjednu.ToString();
            switch (dt)
            {
                // 062 Napisati grane case tako da za svaki radni dan u tjednu vraća "radni dan", a za subotu i nedjelju vraća "vikend"
                case "Saturday":
                case "Sunday":
                    return "vikend";
                    break;
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    return "radni dan";
                    break;
                // 063 Za nepodržane vrijednosti treba baciti iznimku tipa ArgumentOutOfRangeException:
                default:
                    throw new ArgumentOutOfRangeException();
                    

            }
        }

        // 064 Pokrenuti program i provjeriti ispravnost ispisa
        
        // 065 Pokrenuti testove i provjeriti prolaze li svi testovi iz grupe TestGrananjaSwitch
    }
}
