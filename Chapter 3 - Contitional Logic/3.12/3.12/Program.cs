using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;

            if (num >= 1 && num <= 10)  // Corrected condition
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
