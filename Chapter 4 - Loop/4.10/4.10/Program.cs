﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int n = 1; n <= 20; n++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{n} X {i} = {n * i}");
                }
                Console.WriteLine("---------------------------------");
            }
        }
    }
}
