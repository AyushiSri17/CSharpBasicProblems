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

            Console.WriteLine("Please enter first number");
            int first=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int second=Convert.ToInt32(Console.ReadLine());

            Calculator calculator= new Calculator(first, second);
            calculator.Addition();
            calculator.Substraction();
            calculator.Multiplication();
            calculator.Division();
            Console.ReadLine();
        }
    }
}
