using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (n < 10)
            {
                n = n + 1;
                if (n % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(n);
            }
        }
    }
}
