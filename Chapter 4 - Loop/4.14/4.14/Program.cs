using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 3; a++)
            {
                for (int b = 1; b <= 3; b++)
                {
                    for (int c = 1; c <= 3; c++)
                    {
                        if (b != a && c != a && c != b)
                        {
                            Console.WriteLine($"{a}, {b}, {c}");
                        }
                    }
                }
            }
        }
    }
}
