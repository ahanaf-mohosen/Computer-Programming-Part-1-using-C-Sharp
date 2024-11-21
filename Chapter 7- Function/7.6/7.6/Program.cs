using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            int z = 30;

            z = TestFunction(x);
            Console.WriteLine($"{x} {y} {z}");
        }
        static int TestFunction(int x)
        {
            int y = x;
            x = 2 * y;
            return x * y;
        }
    }
}
