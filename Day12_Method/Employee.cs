using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Method
{
    internal class Employee
    {
        #region method create
        static void EmployeeDetails(string name, string depatrment, int salary)
        {

            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Department: {depatrment}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine();

        }
        #endregion


        #region method call
        static void Main(string[] args)
        {
            EmployeeDetails("Hemant Kumar Sharma", "IT", 40000);
            EmployeeDetails("Rahul", "Financec", 40000);
        }
        #endregion
    }
}
