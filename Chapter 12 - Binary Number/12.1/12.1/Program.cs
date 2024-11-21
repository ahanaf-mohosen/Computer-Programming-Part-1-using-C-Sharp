using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the binary number: ");
            string binary = Console.ReadLine();

            int decimalValue = 0;
            int len = binary.Length;
            int power = len - 1;

            for (int i = 0; i < len; i++)
            {
                decimalValue += (binary[i] - '0') * (int)Math.Pow(2, power);
                power--;
            }

            Console.WriteLine("Decimal value is " + decimalValue);
        }
    }
}
