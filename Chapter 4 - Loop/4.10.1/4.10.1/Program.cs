using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 20; n++)
            {
                int m = 0;
                int nn = n;
                for (int i = 1; i <= 10; i++)
                {
                    m += nn;
                    Console.WriteLine($"{n} X {i} = {m}");
                }
                Console.WriteLine("---------------------------------");
            }
        }
    }
}
