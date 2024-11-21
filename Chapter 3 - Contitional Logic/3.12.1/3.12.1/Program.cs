using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._12._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            // Taking input for the character
            ch = Console.ReadKey().KeyChar;

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("{0} is vowel", ch);
            }
            else
            {
                Console.WriteLine("{0} is consonant", ch);
            }
        }
    }
}
