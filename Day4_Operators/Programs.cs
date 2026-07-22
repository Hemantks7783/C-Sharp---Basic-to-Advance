using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Operators
{
    internal class Programs
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition: " + (num1 + num2));
            Console.WriteLine("Subtraction: " + (num1 - num2));
            Console.WriteLine("Multiplication: " + (num1 * num2));
            Console.WriteLine("Division: " + (num1 / num2));
            Console.WriteLine("Modulus: " + (num1 % num2));

            Console.WriteLine("==================================");

            Console.Write("Enter a Third Number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            //sum of three numbers num1, num2, num3 and average of three numbers num1, num2, num3

            Console.WriteLine("sum of three numbers: " + (num1 + num2 + num3));
            Console.WriteLine("average of three numbers: " + (num1 + num2 + num3) / 3);

        }
    }
}
