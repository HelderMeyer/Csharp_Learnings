using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cube(5));
            int cubedNumber = Cube(6);
            Console.WriteLine(cubedNumber);
            Console.ReadLine();
        }
        static int Cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}
