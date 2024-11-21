using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int n, sum;

            // Get user input
            n = Convert.ToInt32(Console.ReadLine());

            // Calculate the summation
            sum = (n * (n + 1)) / 2;

            // Display the result
            Console.WriteLine("Summation is {0}", sum);
        }
    }
}
