using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            SayHi(name);

            Console.ReadLine();
        }
        
        static void SayHi(string name)
        {
            Console.WriteLine("Hello, " + name);
        }

    }
}
