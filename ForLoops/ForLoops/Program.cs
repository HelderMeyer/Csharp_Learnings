using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = {10, 20, 30, 40, 50};
            for(int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
            foreach (int i in luckyNumbers)
            {
                Console.WriteLine(i); //Update
            }
        }
    }
}
