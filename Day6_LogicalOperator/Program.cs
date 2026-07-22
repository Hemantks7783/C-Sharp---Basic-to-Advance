using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AND Operators Both Condition Are True
            Console.Write("Enter Your Age: ");
            int age = int.Parse(Console.ReadLine());

            if(age >=18 && age <= 60)
            {
                Console.WriteLine("Your Are Eligible For Job");
            }
            else
            {
                Console.WriteLine("Your Are Not Eligible For Job");
            }
        }
    }
}
