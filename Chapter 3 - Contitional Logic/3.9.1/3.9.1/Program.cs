using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 77;
            int quotient, product, result;

            quotient = num / 2;
            product = quotient * 2;
            result = num - product;

            if (result == 0)
            {
                Console.WriteLine("{0} is even", num);
            }
            else
            {
                Console.WriteLine("{0} is odd", num);
            }
        }
    }
}
