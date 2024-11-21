using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.Write("Enter the first letter of your name: ");
            ch = Console.ReadKey().KeyChar;  // Read a single key press as a character
            Console.WriteLine();  // Move to the next line after input
            Console.WriteLine("The first letter of your name is: " + ch);
        }
    }
}
