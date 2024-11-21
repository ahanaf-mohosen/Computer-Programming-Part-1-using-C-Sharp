using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int n, sum = 0;

            // Get user input
            Console.Write("Enter a positive integer: ");
            n = Convert.ToInt32(Console.ReadLine());

            // Check if the number is positive
            if (n > 0)
            {
                // Loop to calculate the sum of odd numbers
                for (int i = 1; i <= n; i += 2)
                {
                    sum += i;
                }

                // Display the result
                Console.WriteLine("The sum of odd numbers from 1 to {0} is: {1}", n, sum);
            }
            else
            {
                // Display a message if the number is not positive
                Console.WriteLine("Please enter a positive integer.");
            }
        }
    }
}
