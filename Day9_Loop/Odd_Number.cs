using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Loop
{
    internal class Odd_Number
    {
        static void Main(string[] args)
        {
            //printing odd numbers from 1 to 10 using a for loop
            Console.Write("Enter Your Number: ");
            int number = int.Parse(Console.ReadLine());
            if (number <= number)
            {
                for (int i = 1; i <= number; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
