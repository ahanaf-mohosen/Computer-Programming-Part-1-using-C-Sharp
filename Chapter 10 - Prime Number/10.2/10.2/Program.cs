using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                Console.Write("Please enter a number (enter 0 to exit): ");
                n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    break;
                }
                if (IsPrime(n))
                {
                    Console.WriteLine($"{n} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{n} is not a prime number.");
                }
            }
        }
        static bool IsPrime(int n)
        {
            if (n < 2) // Handle numbers less than 2
            {
                return false;
            }
            if (n == 2)
            {
                return true;
            }
            if (n % 2 == 0)
            {
                return false;
            }
            int root = (int)Math.Sqrt(n); // Square root of n
            for (int i = 3; i <= root; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
