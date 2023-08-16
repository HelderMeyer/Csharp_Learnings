using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };

            Console.WriteLine(luckyNumbers[0]);

            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers[1]);

            string[] friends = new string[5];
            friends[0] = "Sarah";
            friends[1] = "Filipe";
            friends[2] = "Marcelo";
            friends[3] = "Felipe";
            friends[4] = "Alberto";

            Console.ReadLine();
        }
    }
}
