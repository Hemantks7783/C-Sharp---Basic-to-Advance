using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Method
{
    internal class Methods_with_Parameters
    {
        static void PrintName(string name)
        {
            Console.WriteLine($"Welcome :{name}");
        }

        static void Main(string[] args)
        {
            PrintName("Hemant");
            PrintName("Rahul");
            PrintName("Sharma");

        }
    }
}
