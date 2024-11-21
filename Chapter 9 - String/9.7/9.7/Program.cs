using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "bangla";
            string str2 = "desh";
            char[] str3 = new char[str1.Length + str2.Length + 1];

            int i, j;
            for (i = 0, j = 0; i < str1.Length; i++, j++)
            {
                str3[j] = str1[i];
            }

            for (i = 0; i < str2.Length; i++, j++)
            {
                str3[j] = str2[i];
            }

            str3[j] = '\0';

            Console.WriteLine(new string(str3, 0, j)); // Convert char array to string for output
        }
    }
}
