using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            // Getting user input for the first number
            Console.Write("Please enter a number: ");
            num1 = int.Parse(Console.ReadLine());

            // Getting user input for the second number
            Console.Write("Please enter another number: ");
            num2 = int.Parse(Console.ReadLine());

            // Performing and displaying arithmetic operations
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
        }
    }
}
