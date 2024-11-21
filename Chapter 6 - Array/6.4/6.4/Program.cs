using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ara = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}th element is: {ara[i]}");
            }
        }
    }
}
