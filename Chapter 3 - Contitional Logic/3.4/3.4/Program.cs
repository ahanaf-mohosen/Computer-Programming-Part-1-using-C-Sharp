using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            if (n < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else if (n > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else
            {
                Console.WriteLine("The number is zero!");
            }
        }
    }
}
