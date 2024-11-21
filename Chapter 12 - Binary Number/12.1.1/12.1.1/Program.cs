using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Binary representation of " + num + " is: ");
            DecimalToBinary(num);
            Console.WriteLine();
        }
        static void DecimalToBinary(int n)
        {
            if (n > 1)
            {
                DecimalToBinary(n / 2);
            }
            Console.Write(n % 2);
        }
    }
}
