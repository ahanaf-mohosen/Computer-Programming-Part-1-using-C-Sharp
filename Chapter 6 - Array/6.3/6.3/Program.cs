using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ara = { 6, 7, 4, 6, 9 };

            try
            {
                Console.WriteLine(ara[-1]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index -1 is out of bounds.");
            }

            try
            {
                Console.WriteLine(ara[5]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index 5 is out of bounds.");
            }

            try
            {
                Console.WriteLine(ara[100]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index 100 is out of bounds.");
            }
        }
    }
}
