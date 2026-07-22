using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Loop
{
    internal class Factorial_Number
    {
        static void Main(string[] args)
        {
          
                //Factorial of a Number
                Console.Write("Enter Your Numbers: ");
                int number = int.Parse(Console.ReadLine());
                int factorial = 1;
                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine($"Factorial of {number} is: {factorial}");
            
        }
        
    }
}
