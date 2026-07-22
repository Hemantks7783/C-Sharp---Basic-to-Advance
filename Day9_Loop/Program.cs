using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //printing numbers from 1 to 10 using a for loop
            Console.Write("Enter Your Number: ");
            int number = int.Parse(Console.ReadLine());

            if(number <= 10)
            {
                for(int i = 1; i<=number;i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
              Console.WriteLine("Please enter a number less than or equal to 10.");
            }
        }
    }
}
