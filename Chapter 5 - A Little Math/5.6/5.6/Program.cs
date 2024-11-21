using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int i, n, sum;

            // Get user input
            n = Convert.ToInt32(Console.ReadLine());

            // Calculate the summation using a loop
            sum = 0;
            for (i = 1; i <= n; i++)
            {
                sum += i;
            }

            // Display the result
            Console.WriteLine("Summation is {0}", sum);
        }
    }
}
