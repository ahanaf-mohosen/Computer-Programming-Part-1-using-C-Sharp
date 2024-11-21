using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._3
{
    internal class Program
    {
        const int size = 40;
        static int[] ara = new int[size];
        static void Main(string[] args)
        {
            int n;
            Sieve();

            while (true)
            {
                Console.Write("Please enter a number (enter 0 to exit): ");
                n = int.Parse(Console.ReadLine());

                if (n == 0)
                {
                    break;
                }
                if (n >= size)
                {
                    Console.WriteLine($"The number should be less than {size}");
                    continue;
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

        static void PrintAra()
        {
            for (int i = 2; i < size; i++)
            {
                Console.Write($"{ara[i],4}");
            }
            Console.WriteLine();

            for (int i = 2; i < size; i++)
            {
                Console.Write("----");
            }
            Console.WriteLine();

            for (int i = 2; i < size; i++)
            {
                Console.Write($"{i,4}");
            }
            Console.WriteLine("\n\n\n");
        }

        static void Sieve()
        {
            for (int i = 2; i < size; i++)
            {
                ara[i] = 1;
            }

            int root = (int)Math.Sqrt(size);
            PrintAra();

            for (int i = 2; i <= root; i++)
            {
                if (ara[i] == 1)
                {
                    for (int j = 2; i * j < size; j++)
                    {
                        ara[i * j] = 0;
                    }
                    PrintAra();
                }
            }
        }

        static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            return ara[n] == 1;
        }
    }
}
