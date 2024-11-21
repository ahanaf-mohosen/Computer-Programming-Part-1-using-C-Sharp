using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] country = { 'B', 'a', 'n', 'g', 'l', 'a', 'd', 'e', 's', 'h', '\0', 'i', 's', ' ', 'm', 'y', ' ', 'c', 'o', 'u', 'n', 't', 'r', 'y' };
            string countryString = new string(country, 0, Array.IndexOf(country, '\0'));
            Console.WriteLine(countryString);
        }
    }
}
