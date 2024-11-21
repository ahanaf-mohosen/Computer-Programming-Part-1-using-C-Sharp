using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, remainder;
            number = 5;
            remainder = number % 2;

            if (remainder == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
