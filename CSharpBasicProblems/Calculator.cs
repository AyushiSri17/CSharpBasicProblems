using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasicProblems
{
    //Defining class naming calculator
    internal class Calculator
    {
        //Instance Variables
        public int first, second, sum, difference, mult;
        public float div;

        //Constructor for initialization
        public Calculator(int firstNumber, int secondNumber)
        { 
            first = firstNumber;
            second = secondNumber;
        }

        //Additon method declaration
        public void Addition()
        { 
            sum = first + second;
            Console.WriteLine("Addition of two number is: "+sum);
        }
        //Substraction method declaration
        public void Substraction()
        {
            difference = Math.Abs(first - second);
            Console.WriteLine("Substraction of two number is: " + difference);
        }
        //Multiplication method declaration
        public void Multiplication()
        {
            mult = first * second;
            Console.WriteLine("Multiplication of two number is: " + mult);
        }
        //Division method declaration
        public void Division()
        {
           div = (float)first / second;
            Console.WriteLine("Division of two number is: " + div);
        }
    }
}
