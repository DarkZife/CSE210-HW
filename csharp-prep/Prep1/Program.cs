using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name");
        String FName = Console.WriteLine();
        Console.WriteLine("What is your last name?");
        String LName = Console.ReadLine();

        Console.WriteLine($"Your name is {LName}, {FName} {LName})
    }
}