using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the day of the week (1-7): ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Today is " + Day(day));
            Console.ReadLine();
        }
        static string Day(int day)
        {
            string result;
            switch (day)
            {
                case 1: 
                    result = "Monday"; 
                    break;
                case 2: 
                    result = "Tuesday"; 
                    break;
                case 3: 
                    result = "Wednesday"; 
                    break;
                case 4: 
                    result = "Thursday"; 
                    break;
                case 5: 
                    result = "Friday"; 
                    break;
                case 6: 
                    result = "Saturday"; 
                    break;
                case 7: 
                    result = "Sunday"; 
                    break;
                default: 
                    result = "Invalid Number"; 
                    break;
            }
            return result;
        }
    }
}
