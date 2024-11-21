using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ara1 = { 3, 1, 5, 2, 4 };
            int[] ara2 = new int[5];
            int minimum, index_2, minimumIndex = -1;

            for (index_2 = 0; index_2 < 5; index_2++)
            {
                minimum = 10000;
                for (int i = 0; i < 5; i++)
                {
                    if (ara1[i] < minimum)
                    {
                        minimum = ara1[i];
                        minimumIndex = i;
                    }
                }
                ara1[minimumIndex] = 10000;
                ara2[index_2] = minimum;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(ara2[i]);
            }
        }
    }
}
