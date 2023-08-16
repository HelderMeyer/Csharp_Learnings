using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gender, name;
            int age;
            double height;
            Console.Write("What is your name: ");
            name = Console.ReadLine();
            Console.Write("What is your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your height (in Meters): ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is your gender: ");
            gender = Console.ReadLine();

            if (gender.ToUpper() == "MALE")
            {
                Console.WriteLine("Your name is " + name + " and you are " + age + " years old.");
                if(height > 1.7)
                {
                    Console.WriteLine("You are a male and tall.");
                }else
                {
                    Console.WriteLine("You are a male and short.");
                }
            }
            else if(gender.ToUpper() == "FEMALE")
            {
                Console.WriteLine("Your name is " + name + " and you are " + age + " years old.");
                if (height > 1.7)
                {
                    Console.WriteLine("You are a male and tall.");
                }
                else
                {
                    Console.WriteLine("You are a male and short.");
                }
            }
            else
            {
                Console.WriteLine("It's a different gender.");
            }

            Console.ReadLine();
        }
    }
}
