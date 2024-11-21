using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2.5;
            double b = 2.5;
            double c = Add(a, b);

            Console.WriteLine(c);
        }
        static double Add(double num1, double num2)
        {
            double sum = num1 + num2;
            return sum;
        }
    }
}
