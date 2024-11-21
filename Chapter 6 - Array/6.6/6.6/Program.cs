using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ara = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int temp;

            for (int i = 0, j = 9; i < 10 / 2; i++, j--) // i < j condition is also valid
            {
                temp = ara[j];
                ara[j] = ara[i];
                ara[i] = temp;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(ara[i]);
            }
        }
    }
}
