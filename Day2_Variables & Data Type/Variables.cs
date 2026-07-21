using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables___Data_Type
{
    internal class Variables
    {
        static void Main(string[] args)
        {
            string name = "Hemant Kumar Sharma";
            int age = 28;
            double height = 5.0;
            string course = "DotNet";
            char day = 'A';
            bool isStudent = true;
            string city = "New Delhi";

            Console.WriteLine("--- Student Details ---");
            Console.WriteLine("My name is:" + name);
            Console.WriteLine($"My Age is {age}");
            Console.WriteLine($"heigth: {height:F1}");
            
            Console.WriteLine($"my course is {course}");
            Console.WriteLine(day);
            Console.WriteLine($"my city is {city}");
            Console.WriteLine(isStudent);

        }

    } 



}
    
