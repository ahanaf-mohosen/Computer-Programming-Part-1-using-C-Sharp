using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] total_marks = { 86, 78, 94, 68, 92, 78, 64, 62, 72, 61, 72, 66, 65, 65, 80, 72, 62, 68, 81, 62, 56, 68, 58, 56, 82, 70, 74, 78, 76, 84, 88, 73, 62, 66, 76, 70, 67, 65, 77, 63 };
            int[] marks_count = new int[101];

            for (int i = 0; i < 101; i++)
            {
                marks_count[i] = 0;
            }

            for (int i = 0; i < total_marks.Length; i++)
            {
                marks_count[total_marks[i]]++;
            }

            for (int i = 50; i <= 100; i++)
            {
                Console.WriteLine($"Marks: {i} Count: {marks_count[i]}");
            }
        }
    }
}
