using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Method
{
    internal class Program2
    {
        //Create a method named:
        static void PrintName()
        {
            Console.WriteLine("My Name is : Hemant Kumar Sharma");

        }

        static void PrintCity()
        {
          Console.WriteLine("My City is : New Delhi");
        }

        static void PrintCourse()
        {
            Console.WriteLine("My Course is : C# Programming");
        }

        //Calling the method from Main method.
        static void Main(string[] args)
        {
            PrintName();
            PrintCity();
            PrintCourse();
        }
    }
}
