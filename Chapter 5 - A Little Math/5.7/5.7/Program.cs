using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;
            Console.Write("Enter the temperature in celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = 1.8 * celsius + 32;
            Console.WriteLine($"Temperature in fahrenheit is: {fahrenheit}");
        }
    }
}
