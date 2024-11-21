using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ara = { 1, 2, 3, 4, 5 };

            Console.WriteLine(ara[0]);
            TestFunction(ara);
            Console.WriteLine(ara[0]);
        }
        static void TestFunction(int[] ara)
        {
            ara[0] = 100;
        }
    }
}
