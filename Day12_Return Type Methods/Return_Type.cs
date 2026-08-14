using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Return_Type_Methods
{
    internal class Return_Type
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        int result = Add(30, 20);
        static void Main(string[] args)
        {
            Return_Type obj = new Return_Type();
            Console.WriteLine("The sum of two numbers is: " + obj.result);
            Console.ReadLine();
        }
    }
}