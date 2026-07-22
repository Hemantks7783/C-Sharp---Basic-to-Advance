using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Loop
{
    internal class Sum_Of_Number
    {
        static void Main(string[] args)
        {
            //Sum of First N Numbers
            Console.Write("Enter Your Number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                
                sum += i;
            }
            Console.WriteLine($"Sum of First {number} Numbers is: {sum}");
       
        }
    }
}
