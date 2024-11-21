using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_13._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 6;

            // Upper part of the pattern (inverted pyramid)
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    // Printing spaces
                    Console.Write(" ");
                }
                for (int j = 0; j < (2 * (rows - i) - 1); j++)
                {
                    // Printing 'c' characters
                    Console.Write("c");
                }
                Console.WriteLine();
            }

            // Lower part of the pattern (normal pyramid)
            for (int i = 1; i < rows; i++)
            {
                for (int j = 0; j < (rows - i - 1); j++)
                {
                    // Printing spaces
                    Console.Write(" ");
                }
                for (int j = 0; j < (2 * i + 1); j++)
                {
                    // Printing 'c' characters
                    Console.Write("c");
                }
                Console.WriteLine();
            }
        }
    }
}
