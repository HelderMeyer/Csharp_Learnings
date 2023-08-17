using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExponentMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the base number: ");
            int baseNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the pow number: ");
            int powNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(baseNumber + "^" + powNumber + " = " + GetPow(baseNumber, powNumber));

            Console.ReadLine();
        }

        static int GetPow(int baseNumber, int powNumber)
        {
            int result = 1;

            for (int i = 0; i < powNumber; i++)
            {
                result = result * baseNumber;
            }

            return result;
        }
    }
}
