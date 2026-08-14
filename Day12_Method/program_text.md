Real-Life Flow

Main()

↓

Welcome();

↓

Welcome Method

↓

Print Message

↓

Back to Main()



# Calling a Method Multiple Times
using System;

class Program
{
    static void Welcome()
    {
        Console.WriteLine("Welcome Hemant");
    }

    static void Main()
    {
        Welcome();
        Welcome();
        Welcome();
    }
}