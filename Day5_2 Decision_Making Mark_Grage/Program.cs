using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Decision_Making
{
    internal class Program
    {
        static void Main(string[] srgd)
        {
            Console.Write("Enter your Math marks: ");
            int mathMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter your Science marks: ");
            int scienceMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter your English marks: ");
            int englishMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter your Social Science marks: ");
            int SocialScienceMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter your Hindi marks: ");
            int hindiMarks = int.Parse(Console.ReadLine());

            //Logic to calculate total marks and percentage
            int totalMarks = mathMarks + scienceMarks + englishMarks + SocialScienceMarks + hindiMarks;
            float percentage = (float)totalMarks / 5;
            Console.WriteLine("Total Marks: " + totalMarks);
            Console.WriteLine("Percentage: " + percentage + "%");

            if (percentage >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (percentage >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (percentage >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (percentage >= 60)
            {
                Console.WriteLine("Grade: D");
            }
            else if (percentage >= 50)
            {
                Console.WriteLine("Grade: E");
            }
            else
            {
                Console.WriteLine("Faill");
            }

        }
    }
}
