﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var oddNumbersCount = int.Parse(Console.ReadLine());
            var sumOfOddNumbers = 0;
            for (int i = 1; i < oddNumbersCount * 2; i += 2)
            {
                sumOfOddNumbers += i;
                Console.WriteLine(i);
            }

            Console.WriteLine($"Sum: {sumOfOddNumbers}");
        }
    }
}
