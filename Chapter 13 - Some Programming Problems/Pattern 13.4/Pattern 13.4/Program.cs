using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_13._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 10;

            // Loop to print the upper part of the pattern
            for (int i = 1; i <= rows; i++)
            {
                // Print 'c' characters for the left side
                for (int j = 0; j < i; j++)
                {
                    Console.Write("c");
                }

                // Print spaces in between
                for (int j = 0; j < (rows - i) * 2; j++)
                {
                    Console.Write(" ");
                }

                // Print 'c' characters for the right side
                for (int j = 0; j < i; j++)
                {
                    Console.Write("c");
                }

                // Move to the next line
                Console.WriteLine();
            }
        }
    }
}
