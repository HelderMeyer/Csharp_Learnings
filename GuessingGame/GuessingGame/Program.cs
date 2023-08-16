using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Helder";
            string guess = "";
            while (guess != name)
            {
                Console.Write("What is my name: ");
                guess = Console.ReadLine();
            }
            Console.WriteLine("You won!");
            Console.ReadLine();
        }
    }
}
