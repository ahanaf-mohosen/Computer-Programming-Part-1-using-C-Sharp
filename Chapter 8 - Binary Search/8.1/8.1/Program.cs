using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ara = { 1, 4, 6, 8, 9, 11, 14, 15, 20, 25, 33, 83, 87, 97, 99, 100 };
            int lowIndx = 0;
            int highIndx = ara.Length - 1;
            int midIndx = -1;
            int num = 97;

            while (lowIndx <= highIndx)
            {
                midIndx = (lowIndx + highIndx) / 2;
                if (num == ara[midIndx])
                {
                    break;
                }
                if (num < ara[midIndx])
                {
                    highIndx = midIndx - 1;
                }
                else
                {
                    lowIndx = midIndx + 1;
                }
            }

            if (lowIndx > highIndx)
            {
                Console.WriteLine($"{num} is not in the array.");
            }
            else
            {
                Console.WriteLine($"{ara[midIndx]} is found in the array. It is the {midIndx + 1}th element of the array.");
            }
        }
    }
}
