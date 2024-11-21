using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a1, a2, b1, b2, c1, c2, x, y;

            // Input values for a1, a2, b1, b2, c1, c2
            Console.Write("a1 = ");
            a1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("a2 = ");
            a2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("b1 = ");
            b1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("b2 = ");
            b2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("c1 = ");
            c1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("c2 = ");
            c2 = Convert.ToDouble(Console.ReadLine());

            // Cramer's rule to calculate x and y
            double denominator = a1 * b2 - a2 * b1;
            x = (b2 * c1 - b1 * c2) / denominator;
            y = (a1 * c2 - a2 * c1) / denominator;

            // Output the result
            Console.WriteLine($"x = {x:F2}, y = {y:F2}");
        }
    }
}
