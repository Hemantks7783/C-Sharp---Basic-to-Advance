using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_Loop__Condition
{
    internal class For_Loop
    {
        static void Main(string[]args)
        {
            // print number from 1 to 100
            
            Console.Write("Enter Your number Till You Print : ");
            int num = int.Parse(Console.ReadLine());
            //logic for loop
            for (int i =1; i <= num; i++)
            {
                Console.WriteLine(i);  
            }
        }
    }
}
