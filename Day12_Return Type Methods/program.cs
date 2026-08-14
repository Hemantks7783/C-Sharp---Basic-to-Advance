using System;

namespace Day12_Return_Type_Methods
{
    internal class Program
    {
        static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int result = Add(firstNumber, secondNumber);

            Console.WriteLine($"The sum is: {result}");
            Console.ReadLine();
        }
    }
}