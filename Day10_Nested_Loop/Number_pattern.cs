using System;
namespace Day10_Nested_Loop
{
    internal class Number_pattern
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Number of Rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter The Number of Columns: ");
            int col = int.Parse(Console.ReadLine());

            // Outer loop for rows
            for (int i = 0; i < rows; i++)
            {
                // Inner loop for columns
                for (int j = 0; j < col; j++)
                {
                    Console.Write(j + 1 + " ");
                }
                //Console.Write(i + 1 + " ");
                / Console.Write(' ');
            }
        }
    }
}