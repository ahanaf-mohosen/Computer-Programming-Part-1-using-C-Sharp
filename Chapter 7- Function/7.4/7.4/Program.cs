using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2.8;
            double b = 2.7;

            double c = Add(a, b);
            Console.WriteLine(c);
        }
        static double Add(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}
