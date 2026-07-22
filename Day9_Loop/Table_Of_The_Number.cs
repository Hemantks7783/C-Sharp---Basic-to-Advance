using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Loop
{
    internal class Table_Of_The_Number
    {
        static void Main(string[] args)
        {
            //printing table of the number using a for loop
           Console.Write("Enter Your Number: ");
           int number = int.Parse(Console.ReadLine());
           for(int i = 1; i<=10; i++)
            {
              Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
    }
}
