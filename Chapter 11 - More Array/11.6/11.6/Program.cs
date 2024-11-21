using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] ara1 = new int[5, 5]
        {
            { 1, 2, 3, 4, 5 },
            { 10, 20, 30, 40, 50 },
            { 100, 200, 300, 400, 500 },
            { 1000, 2000, 3000, 4000, 5000 },
            { 10000, 20000, 30000, 40000, 50000 }
        };
            int[,] ara2 = new int[5, 5];

            Console.WriteLine("Content of first array (ara1):");
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(ara1[r, c] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Copying the data from ara1 to ara2 (transposing the matrix)
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    ara2[c, r] = ara1[r, c];
                }
            }

            Console.WriteLine("Content of second array (ara2):");
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(ara2[r, c] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
