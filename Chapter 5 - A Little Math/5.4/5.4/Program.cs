using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            double loanAmount, interestRate, numberOfYears, totalAmount, monthlyAmount;

            // Get user inputs
            Console.Write("Enter the loan amount: ");
            loanAmount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the interest rate: ");
            interestRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Number of years: ");
            numberOfYears = Convert.ToDouble(Console.ReadLine());

            // Calculate total amount and monthly amount
            totalAmount = loanAmount + loanAmount * numberOfYears * interestRate / 100.00;
            monthlyAmount = totalAmount / (numberOfYears * 12);

            // Display results
            Console.WriteLine("Total amount: {0:F2}", totalAmount);
            Console.WriteLine("Monthly amount: {0:F2}", monthlyAmount);
        }
    }
}
