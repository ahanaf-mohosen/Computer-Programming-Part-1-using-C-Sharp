using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            char c;

            Console.Write("Please enter the initial position: ");
            string[] position = Console.ReadLine().Split();
            x = int.Parse(position[0]);
            y = int.Parse(position[1]);

            while (true)
            {
                c = Console.ReadKey().KeyChar; // Read a single character input
                if (c == 'S')
                {
                    break;
                }
                else if (c == 'U')
                {
                    x--;
                }
                else if (c == 'D')
                {
                    x++;
                }
                else if (c == 'R')
                {
                    y++;
                }
                else if (c == 'L')
                {
                    y--;
                }
            }

            Console.WriteLine($"\nFinal position of the robot is: {x}, {y}");
        }
    }
}
