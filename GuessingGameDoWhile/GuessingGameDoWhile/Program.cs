using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Helder";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != name && !outOfGuesses)
            {
                if(guessCount < guessLimit)
                {
                Console.Write("What is my name: ");
                guess = Console.ReadLine();
                guessCount++;
                Console.WriteLine("Attempt " +  guessCount + "/" + guessLimit);
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You lost.");
            }
            else
            {
            Console.WriteLine("You won!");
            }
            Console.ReadLine();
        }
    }
}
