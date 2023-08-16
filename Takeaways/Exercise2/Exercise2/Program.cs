using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Helder Meyer";
            Console.WriteLine(name.Length); // It will tell me how many characters
                                            // are inside of this string
            Console.WriteLine(name.ToUpper()); // It will convert my string content to uppercase
            Console.WriteLine(name.ToLower()); // It will convert my string content to lowercase
            Console.WriteLine(name.Contains("s")); // It will return true of false whether or not the phrase in "name" string contains the word "s"
            Console.WriteLine(name[0]); // It will tell me what is the letter in the first position of the string "name"
            Console.WriteLine(name.IndexOf("r")); // It'll tell me the position "index" where the "M" is
            Console.WriteLine(name.Substring(7, 3)); // It'll get the words starting from the 7 position and it will get only 3 words
            Console.ReadLine();
        }
    }
}
