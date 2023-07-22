using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");

            if (num2 != 0)
            {
                double division = (double)num1 / num2;
                double modulus = num1 % num2;

                Console.WriteLine($"Division: {division}");
                Console.WriteLine($"Modulus: {modulus}");
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
            }
        }
    }
}
