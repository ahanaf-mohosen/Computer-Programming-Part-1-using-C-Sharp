using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int i = 1;
            for (; ; )
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
                i = i + 1;
                if (i > 10)
                {
                    break;
                }
            }
        }
    }
}
