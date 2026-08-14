using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print array elements 
           
            Console.Write("Enter the size of array: ");
            int ArraySize = int.Parse(Console.ReadLine());
            int[] array = new int[ArraySize];
            for (int i = 0; i < ArraySize; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The elements of the array are:");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            //search an element in the array

            Console.WriteLine("Enter the element to search: ");
            int searchElement = int.Parse(Console.ReadLine());
            Console.WriteLine("Your Search Elements are : " + searchElement);
            bool found = false;
            foreach (int i in array)
            {
                Console.WriteLine(i);
                if (i == searchElement)
                {
                    found = true;
                    break;
                }

            }
            if (found)
            {
                Console.WriteLine($"Element {searchElement} found in the array.");
            }
            else
            {
                Console.WriteLine($"Element {searchElement} not found in the array.");
            }

            //find maximum number in the array
            #region Maximum
            int max = array.Max();
            Console.WriteLine("The maximum number in the array is: " + max);
            #endregion

            //find minimum element in the array
            int min = array.Min();
            Console.WriteLine("The minimum number in the array is: " + min);

            //calculate sum of all elements in the array

            Console.WriteLine("The sum of all elements in the array is: " + array.Sum());

            //calculate average of all elements in the array
            Console.WriteLine("The average of all elements in the array is: " + array.Average());

            //reverse the array
            Array.Reverse(array);
            Console.WriteLine("The elements of the array in reverse order are:");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            //sort the array
            Array.Sort(array);
            Console.WriteLine("The elements of the array in sorted order are:");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
