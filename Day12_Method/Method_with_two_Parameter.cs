using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Method
{
    internal class Method_with_two_Parameter
    {
        static void StudentDetails(string name, int age)
        {
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            StudentDetails("Hemant", 25);
            StudentDetails("Rahul", 30);
            StudentDetails("Sharma", 28);
        }
    }
}
