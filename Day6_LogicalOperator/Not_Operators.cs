using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_LogicalOperator
{
    internal class Not_Operators
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Login Id: ");
            int login_Id = int.Parse(Console.ReadLine());
            
            // Logic

        int valid_login_Id = 12345;
         if(!(login_Id == valid_login_Id))
            {
                Console.WriteLine("Invilad Login Id");
            }
            else
                {
                    Console.WriteLine($"Login Id is : {login_Id} and Login Sucess Full");
            }
        }
    }
}
