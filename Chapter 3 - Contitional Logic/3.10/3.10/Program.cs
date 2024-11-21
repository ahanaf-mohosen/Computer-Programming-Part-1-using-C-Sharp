using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch = 'W';

            if (ch >= 'a' && ch <= 'z')
            {
                Console.WriteLine("{0} is lower case", ch);
            }
            if (ch >= 'A' && ch <= 'Z')
            {
                Console.WriteLine("{0} is upper case", ch);
            }
        }
    }
}
