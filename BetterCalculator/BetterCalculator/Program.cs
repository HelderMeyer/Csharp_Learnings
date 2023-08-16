using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BETTER CALCULATOR\n");
            Console.Write("Enter a number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Operator: ");
            string myOperator = Console.ReadLine();
            Console.Write("Enter another number: ");
            double secondNumber = Convert.ToDouble(Console.ReadLine());
            double result = Calculator(firstNumber,secondNumber,myOperator);
            Console.WriteLine("\nThe result of " + firstNumber + " " +  myOperator + " " +  secondNumber + " is " + result);
            Console.ReadLine();
        }

        static double Calculator(double firstNumber, double secondNumber, string myOperator)
        {
            double result = 0;
            if (myOperator == "+")
            {
                result = firstNumber + secondNumber;
            }else if(myOperator == "-")
            {
                result = firstNumber - secondNumber;
            }else if(myOperator == "*")
            {
                result = firstNumber * secondNumber;
            }else if(myOperator == "/")
            {
                result = firstNumber / secondNumber;
            }else if(myOperator == "^")
            {
                result = Math.Pow(firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
                return 0;
            }
            return result;
        }
    }
}
