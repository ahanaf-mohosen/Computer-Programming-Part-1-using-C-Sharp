using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, t, gcd;

            string[] input = Console.ReadLine().Split();
            a = Convert.ToInt32(input[0]);
            b = Convert.ToInt32(input[1]);

            if (a == 0)
            {
                gcd = a;
            }
            else if (b == 0)
            {
                gcd = b;
            }
            else
            {
                while (b != 0)
                {
                    t = b;
                    b = a % b;
                    a = t;
                    Console.WriteLine($"a={a}, b={b}");
                }
                gcd = a;
            }

            Console.WriteLine($"GCD is {gcd}");
        }
    }
}
