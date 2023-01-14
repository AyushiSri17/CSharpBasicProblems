using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO C# PROGRAM");
            Console.WriteLine("Please choose any one program from the given options");
            Console.WriteLine(" 1: Calculator \n 2:WeekDay \n 10:EXit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                //For Calculator
                case 1:
                    Console.WriteLine("Please enter first number");
                    int first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter second number");
                    int second = Convert.ToInt32(Console.ReadLine());
                    Calculator calculator = new Calculator(first, second);
                    calculator.Addition();
                    calculator.Substraction();
                    calculator.Multiplication();
                    calculator.Division();
                    Console.ReadLine();
                    break;
                //For WeekDay 
                case 2:
                    Console.WriteLine("Please choose a day");
                    int day = Convert.ToInt32(Console.ReadLine());
                    WeekDays.FindADayOfWeek(day);
                    Console.ReadLine();
                    break;
                case 10:
                    Console.WriteLine("No program to perform byee!!");
                    break;
                default:
                    Console.WriteLine("Choose the correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
