using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] country = { 'B', 'a', 'n', 'g', 'l', 'a', 'd', 'e', 's', 'h' };
            int length = 10;

            Console.WriteLine(new string(country));

            for (int i = 0; i < length; i++)
            {
                if (country[i] >= 'a' && country[i] <= 'z')
                {
                    country[i] = (char)('A' + (country[i] - 'a'));
                }
            }

            Console.WriteLine(new string(country));
        }
    }
}
