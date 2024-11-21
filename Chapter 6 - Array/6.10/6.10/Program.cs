using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] total_marks = { 6, 7, 4, 6, 9, 7, 6, 2, 4, 3, 4, 1 };
            int[] marks_count = new int[11];

            Console.WriteLine("1 2 3 4 5 6 7 8 9");
            Console.WriteLine("-----------------");

            for (int i = 0; i < 12; i++)
            {
                marks_count[total_marks[i]]++;

                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{marks_count[j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
