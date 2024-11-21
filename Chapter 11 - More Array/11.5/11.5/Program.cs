using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] saarc = { "Bangladesh", "India", "Pakistan", "Sri Lanka", "Nepal", "Bhutan", "Maldives" };

            // Loop through each country name
            for (int row = 0; row < saarc.Length; row++)
            {
                string country = saarc[row];
                int nameLength = country.Length;

                // Loop through each character of the country name
                for (int col = 0; col < nameLength; col++)
                {
                    Console.Write($"({row}, {col}) = {country[col]}, ");
                }
                Console.WriteLine();  // Print newline after each country's characters
            }
        }
    }
}
