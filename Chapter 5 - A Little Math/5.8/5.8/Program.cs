using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, x, gcd = 1;
            string[] input = Console.ReadLine().Split();
            a = Convert.ToInt32(input[0]);
            b = Convert.ToInt32(input[1]);

            for (x = (a < b) ? a : b; x >= 1; x--)
            {
                if (a % x == 0 && b % x == 0)
                {
                    gcd = x;
                    break;
                }
            }
            Console.WriteLine($"GCD is {gcd}");
        }
    }
}
