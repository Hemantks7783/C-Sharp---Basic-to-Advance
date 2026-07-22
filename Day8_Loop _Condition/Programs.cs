using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Loop__Condition
{
    internal class Programs
    {
        //Repeating input until the user enters valid data.

        static void Main(string[] args)
        {
            int number;
            bool isValidInput = false;
            while (!isValidInput)
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    isValidInput = true;
                    Console.WriteLine($"You entered a valid number: {number}");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }
    }
}
