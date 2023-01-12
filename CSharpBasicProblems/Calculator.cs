using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicProblems
{
    internal class Calculator
    {
        public int first, second, sum, sub, mult, div;

        public Calculator(int firstNumber, int secondNumber)
        { 
            first = firstNumber;
            second = secondNumber;
        }

        public void Addition()
        { 
            sum = first + second;
            Console.WriteLine("Addition of two number is: "+sum);
        }
        public void Substraction()
        {
            sub = first - second;
            Console.WriteLine("Substraction of two number is: " + sub);
        }
        public void Multiplication()
        {
            mult = first * second;
            Console.WriteLine("Multiplication of two number is: " + mult);
        }
        public void Division()
        {
            div = first / second;
            Console.WriteLine("Division of two number is: " + div);
        }
    }
}
