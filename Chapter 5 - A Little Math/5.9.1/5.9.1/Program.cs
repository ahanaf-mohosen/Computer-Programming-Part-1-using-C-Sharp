using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Enter two integers: ");
            string[] input = Console.ReadLine().Split();
            a = Convert.ToInt32(input[0]);
            b = Convert.ToInt32(input[1]);

            Console.WriteLine($"LCM is {Lcm(a, b)}");
        }

        static int Gcd(int a, int b)
        {
            if (a == 0)
            {
                return a;
            }
            else if (b == 0)
            {
                return b;
            }
            else
            {
                int t;
                while (b != 0)
                {
                    t = b;
                    b = a % b;
                    a = t;
                    Console.WriteLine($"a={a}, b={b}");
                }
                return a;
            }
        }

        static int Lcm(int a, int b)
        {
            return (a * b) / Gcd(a, b);
        }
    }
}
