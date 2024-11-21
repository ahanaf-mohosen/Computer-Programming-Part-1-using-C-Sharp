﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_13._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 7;

            // Upper part of the pattern
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    // Printing spaces
                    Console.Write(" ");
                }
                for (int k = 1; k <= n - i; k++)
                {
                    // Printing 'c' characters
                    Console.Write("c");
                }
                Console.WriteLine();
            }

            // Lower part of the pattern
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n - i; j++)
                {
                    // Printing spaces
                    Console.Write(" ");
                }
                for (int k = 1; k <= i + 1; k++)
                {
                    // Printing 'c' characters
                    Console.Write("c");
                }
                Console.WriteLine();
            }
        }
    }
}
