using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            string reverseWord = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverseWord += word[i];
            }

            Console.WriteLine(reverseWord);

            if (word == reverseWord)
            {
                Console.WriteLine(word + " is a palindrome.");
            }
            else
            {
                Console.WriteLine(word + " is not a palindrome.");
            }
        }
    }
}
