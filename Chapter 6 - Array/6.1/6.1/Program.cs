using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ft_marks, st_marks, final_marks;
            double total_marks;

            ft_marks = 80;
            st_marks = 74;
            final_marks = 97;

            total_marks = ft_marks / 4.0 + st_marks / 4.0 + final_marks / 2.0;

            Console.WriteLine($"{total_marks:0}");
        }
    }
}
