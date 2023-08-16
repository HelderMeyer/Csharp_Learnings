using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string characterName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            //string input = Console.ReadLine();
            //int characterAge;
            //Int32.TryParse(input, out characterAge);
            int characterAge = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your name is " + characterName + " and you are " + characterAge + " years old.");
            Console.ReadLine();
        }
    }
}
