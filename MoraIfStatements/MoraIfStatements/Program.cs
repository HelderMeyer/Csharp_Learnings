﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoraIfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(GetMax(2, 10));
            Console.ReadLine();
        }
        static int GetMax(int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1;
            }else
            {
                result = num2;
            }

            return result;
        }
    }
}
