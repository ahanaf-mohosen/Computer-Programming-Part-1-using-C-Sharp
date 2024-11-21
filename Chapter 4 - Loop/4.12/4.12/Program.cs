using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3 && j != i; j++)
                {
                    for (int k = 1; k <= 3 && k != i && j != k; k++)
                    {
                        Console.WriteLine($"{i}, {j}, {k}");
                    }
                }
            }
        }
    }
}
