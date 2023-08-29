using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name: ");
            string name = Console.ReadLine();
            Console.Write("How old are you: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name is {0} and you are {1}.", name, age);

            Console.ReadLine();
        }
    }
}
