using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreIfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter a number: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            num2 = Int32.Parse(Console.ReadLine());

            if(GetMax(num1, num2) == num1)
            {
                Console.WriteLine(num1 + " > " + num2);
            }
            else
            {
                Console.WriteLine(num2 + " > " + num1);
            }

            Console.ReadLine();
        }

        static int GetMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
        }
    }
}
