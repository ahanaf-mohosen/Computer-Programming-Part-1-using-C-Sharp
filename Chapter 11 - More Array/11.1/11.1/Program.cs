using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] marks = new int[4, 10]
        {
            {80, 70, 92, 78, 58, 83, 85, 66, 99, 81},
            {75, 67, 55, 100, 91, 84, 79, 61, 90, 97},
            {98, 67, 75, 89, 81, 83, 80, 90, 88, 77},
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}  // Placeholder for total marks
        };

            for (int col = 0; col < 10; col++)
            {
                marks[3, col] = (int)(marks[0, col] / 4.0 + marks[1, col] / 4.0 + marks[2, col] / 2.0);
                Console.WriteLine($"Roll No: {col + 1} Total Marks: {marks[3, col]}");
            }
        }
    }
}
