using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;

            // Reading input from the user
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            sum = a + b;

            // Printing the sum
            Console.WriteLine("Sum is: " + sum);
        }
    }
}
