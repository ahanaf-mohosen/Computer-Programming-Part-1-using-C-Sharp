using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ara = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int[] ara2 = new int[10];

            for (int i = 0, j = 9; i < 10; i++, j--)
            {
                ara2[j] = ara[i];
            }

            for (int i = 0; i < 10; i++)
            {
                ara[i] = ara2[i];
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(ara[i]);
            }
        }
    }
}
