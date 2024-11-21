using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ara = { -100, 0, 53, 22, 83, 23, 89, -132, 201, 3, 85 };
            int n = ara.Length;

            int max = FindMax(ara, n);
            Console.WriteLine(max);
        }
        static int FindMax(int[] ara, int n)
        {
            int max = ara[0];
            for (int i = 1; i < n; i++)
            {
                if (ara[i] > max)
                {
                    max = ara[i];
                }
            }
            return max;
        }
    }
}
