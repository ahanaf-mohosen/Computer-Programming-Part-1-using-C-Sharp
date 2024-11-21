using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            double celsius, fahrenheit;

            // Get user input for temperature in Fahrenheit
            Console.Write("Enter the temperature in Fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            // Convert Fahrenheit to Celsius
            celsius = (fahrenheit - 32) / 1.8;

            // Display the result in Celsius
            Console.WriteLine("Temperature in Celsius is: {0}", celsius);
        }
    }
}
