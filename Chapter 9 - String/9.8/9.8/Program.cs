using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char[] word = new char[100];
            int j = 0;
            bool isWordStarted = false;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z')
                {
                    if (!isWordStarted)
                    {
                        isWordStarted = true;
                        word[j] = (char)('A' + s[i] - 'a'); // Capitalize the first letter
                        j++;
                    }
                    else
                    {
                        word[j] = s[i];
                        j++;
                    }
                }
                else if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    if (!isWordStarted)
                    {
                        isWordStarted = true;
                    }
                    word[j] = s[i];
                    j++;
                }
                else if (s[i] >= '0' && s[i] <= '9')
                {
                    if (!isWordStarted)
                    {
                        isWordStarted = true;
                    }
                    word[j] = s[i];
                    j++;
                }
                else
                {
                    if (isWordStarted)
                    {
                        isWordStarted = false;
                        word[j] = '\0'; // Null-terminate the word
                        Console.WriteLine(new string(word, 0, j)); // Print the word
                        j = 0;
                    }
                }
            }
        }
    }
}
