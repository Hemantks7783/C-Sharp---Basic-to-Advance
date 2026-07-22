namespace Day5_Decision_Making
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //voting eligibility
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
        }
    }
}
