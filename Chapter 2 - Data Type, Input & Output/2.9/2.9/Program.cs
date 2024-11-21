using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 9.5, b = 8.743, sum;
            sum = a + b;

            // Printing the sum with full precision
            Console.WriteLine("Sum is: " + sum);

            // Printing the sum with two decimal places
            Console.WriteLine("Sum is: {0:F2}", sum);
        }
    }
}
