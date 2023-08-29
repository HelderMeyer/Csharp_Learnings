using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bradesco2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(num.ToString("F2"));
            Console.WriteLine(num.ToString("C"));
            Console.WriteLine(num.ToString("P"));
            Console.ReadLine();
        }
    }
}
