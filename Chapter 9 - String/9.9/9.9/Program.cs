using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            bool isWordStarted = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z')
                {
                    if (!isWordStarted)
                    {
                        isWordStarted = true;
                        char ch = (char)('A' + s[i] - 'a'); // Capitalize the first letter
                        Console.Write(ch);
                    }
                    else
                    {
                        Console.Write(s[i]);
                    }
                }
                else if ((s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= '0' && s[i] <= '9'))
                {
                    if (!isWordStarted)
                    {
                        isWordStarted = true;
                    }
                    Console.Write(s[i]);
                }
                else
                {
                    if (isWordStarted)
                    {
                        isWordStarted = false;
                        Console.WriteLine(); // Print a new line after a word
                    }
                }
            }
            Console.WriteLine(); // Ensure a final newline at the end
        }
    }
}
