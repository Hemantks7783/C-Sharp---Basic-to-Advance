using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalOperator
{
    internal class Logical_OR
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            //OR Operator

            if (marks >= 50 || marks >= 80)
            {
                Console.WriteLine($"Your Marks is {marks} : Your Are Pass");
            }
            else
            {
                Console.WriteLine($"Your Marks is {marks} : Your Are Faill");
            }
        }
    }
}
