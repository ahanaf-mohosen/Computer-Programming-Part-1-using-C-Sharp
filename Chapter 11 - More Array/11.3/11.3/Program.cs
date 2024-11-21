using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] saarc = { "Bangladesh", "India", "Pakistan", "Sri Lanka", "Nepal", "Bhutan", "Maldives" };

            // Loop through and print each country
            for (int row = 0; row < saarc.Length; row++)
            {
                Console.WriteLine(saarc[row]);
            }
        }
    }
}
