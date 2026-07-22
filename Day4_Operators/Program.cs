using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic Operators
            int a = 10;
            int b = 3;
            Console.WriteLine("Arithmetic Operators:");
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a / b = {a / b}");
            Console.WriteLine($"a % b = {a % b}");
            // Comparison Operators
            Console.WriteLine("\nComparison Operators:");
            Console.WriteLine($"a == b: {a == b}");
            Console.WriteLine($"a != b: {a != b}");
            Console.WriteLine($"a > b: {a > b}");
            Console.WriteLine($"a < b: {a < b}");
            Console.WriteLine($"a >= b: {a >= b}");
            Console.WriteLine($"a <= b: {a <= b}");
            // Logical Operators
            bool x = true;
            bool y = false;
            Console.WriteLine("\nLogical Operators:");
            Console.WriteLine($"x && y: {x && y}");
            Console.WriteLine($"x || y: {x || y}");
            Console.WriteLine($"!x: {!x}");
            // Assignment Operators
            int c = 5;
            Console.WriteLine("\nAssignment Operators:");
            c += 2; // c = c + 2
            Console.WriteLine($"c += 2: {c}");
            c -= 1; // c = c - 1
            Console.WriteLine($"c -= 1: {c}");
            c *= 3; // c = c * 3
            Console.WriteLine($"c *= 3: {c}");
            c /= 2; // c = c / 2
            Console.WriteLine($"c /= 2: {c}");
        }
    }
}
