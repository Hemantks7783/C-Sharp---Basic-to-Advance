using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Statements
{
    internal class TraficLight_System
    {
        static void Main(string[] args)
        {


            Console.Write("Enter the Color of Traffic Light: ");
            string color = Console.ReadLine().ToLower();
            switch (color)
            {
                case "red":
                    Console.WriteLine("Stop");
                    break;
                case "yellow":
                    Console.WriteLine("Get Ready");
                    break;
                case "green":
                    Console.WriteLine("Go");
                    break;
                default:
                    Console.WriteLine("Invalid Color");
                    break;
            }
        }
    }
    
    
}
