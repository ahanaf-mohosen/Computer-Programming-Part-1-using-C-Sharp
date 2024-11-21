using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] namta = new int[10, 10];

            // Fill the namta array with multiplication values
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    namta[row, col] = (row + 1) * (col + 1);
                }
            }

            // Display the multiplication table
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    Console.WriteLine($"{row + 1} x {col + 1} = {namta[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
