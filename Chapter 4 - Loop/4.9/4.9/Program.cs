using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0;
            int n = 5;
            for (int i = 1; i <= 10; i++)
            {
                m = m + n;
                Console.WriteLine($"{n} X {i} = {m}");
            }
        }
    }
}
