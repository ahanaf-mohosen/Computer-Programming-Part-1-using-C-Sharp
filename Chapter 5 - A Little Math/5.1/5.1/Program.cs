using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, xPlusY, xMinusY;

            // Input for x + y
            Console.Write("Enter the value of x + y: ");
            xPlusY = Convert.ToDouble(Console.ReadLine());

            // Input for x - y
            Console.Write("Enter the value of x - y: ");
            xMinusY = Convert.ToDouble(Console.ReadLine());

            // Calculate x and y
            x = (xPlusY + xMinusY) / 2;
            y = (xPlusY - xMinusY) / 2;

            // Output the result
            Console.WriteLine($"x = {x:F2}, y = {y:F2}");
        }
    }
}
