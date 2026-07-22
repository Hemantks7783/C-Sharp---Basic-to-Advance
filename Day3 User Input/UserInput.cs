using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_User_Input
{
    internal class UserInput
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name:");
            string name = Console.ReadLine();
            
            Console.Write("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your City:");
            string city = Console.ReadLine();

            Console.Write("Enter Your Mobile Number:");
            long mob_no = Convert.ToInt64(Console.ReadLine());

            Console.Write("Enter Your Course:");
            string course = Console.ReadLine();


            Console.WriteLine("====== User Profiles ======");
            Console.WriteLine("Your Nme is:" + name);
            Console.WriteLine($"Your Age is: {age}");
            Console.WriteLine("Your City is :"+ city);
            Console.WriteLine($"Your Mobile Number is : {mob_no}");
            Console.WriteLine("Your Course is :" + course);
            Console.WriteLine("===========================");
            
        }
    }
}
