using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n <= 100)
            {
                Console.WriteLine(n);
                n++;
                if (n > 10)
                {
                    break;
                }
            }
        }
    }
}
