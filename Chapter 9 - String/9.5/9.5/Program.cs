using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country;
            while (true)
            {
                country = Console.ReadLine();
                int length = StringLength(country);
                Console.WriteLine($"length: {length}");
            }
        }
        static int StringLength(string str)
        {
            int length = 0;
            foreach (char c in str)
            {
                length++;
            }
            return length;
        }
    }
}
