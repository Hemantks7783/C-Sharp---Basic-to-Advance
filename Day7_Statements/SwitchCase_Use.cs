using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Statements
{
    internal class SwitchCase_Use
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Login Id: ");
            int Login_Id = int.Parse(Console.ReadLine());

            //Logic 
            switch(Login_Id)
            {
                case 12345:
                    Console.WriteLine($"Login Id is : {Login_Id} and Login Sucess Full");
                    break;
                case 54321:
                    Console.WriteLine($"Login Id is : {Login_Id} and Login Sucess Full");
                    break;
                case 67890:
                    Console.WriteLine($"Login Id is : {Login_Id} and Login Sucess Full");
                    break;
                default:
                    Console.WriteLine("Invalid Login Id");
                    break;
            }
        }
    }
}
