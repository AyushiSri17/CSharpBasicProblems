using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicProblems
{
    //Defining class with a name WeekDays
    internal class WeekDays
    {
        //Defining static method using static keyword
        public static void FindADayOfWeek(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("It's Monday ");
                    break;
                case 2:
                    Console.WriteLine("It's Tuesday");
                    break;
                case 3:
                    Console.WriteLine("It's Wednesday");
                    break;
                case 4:
                    Console.WriteLine("It's Thursday");
                    break;
                case 5:
                    Console.WriteLine("It's Friday");
                    break;
                case 6:
                    Console.WriteLine("It's Saturday");
                    break;
                case 7:
                    Console.WriteLine("Yipee It's Funday aka Sunday");
                    break;
                default:
                    Console.WriteLine("There are only 7 days in a week so Enter number between 1 to 7");
                    break;
            }
        }
    }
}
