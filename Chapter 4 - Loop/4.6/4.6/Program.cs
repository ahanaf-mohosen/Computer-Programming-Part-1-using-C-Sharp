﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
                i = i + 1;
            }
        }
    }
}
