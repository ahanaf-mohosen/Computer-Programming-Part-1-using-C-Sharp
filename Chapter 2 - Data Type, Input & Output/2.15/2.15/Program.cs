using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, value;
            char sign;

            // Getting user input for the first number
            Console.Write("Please enter a number: ");
            num1 = int.Parse(Console.ReadLine());

            // Getting user input for the second number
            Console.Write("Please enter another number: ");
            num2 = int.Parse(Console.ReadLine());

            // Addition operation
            value = num1 + num2;
            sign = '+';
            Console.WriteLine("{0} {1} {2} = {3}", num1, sign, num2, value);

            // Subtraction operation
            value = num1 - num2;
            sign = '-';
            Console.WriteLine("{0} {1} {2} = {3}", num1, sign, num2, value);

            // Multiplication operation
            value = num1 * num2;
            sign = '*';
            Console.WriteLine("{0} {1} {2} = {3}", num1, sign, num2, value);

            // Division operation
            value = num1 / num2;
            sign = '/';
            Console.WriteLine("{0} {1} {2} = {3}", num1, sign, num2, value);
        }
    }
}
