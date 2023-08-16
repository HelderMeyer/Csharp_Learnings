using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            while (index <= 10)
            {
                Console.WriteLine(index);
                index++;
            }
            do
            {
                Console.WriteLine(index);
            } while (index < 10);
            Console.ReadLine();
        }
    }
}
