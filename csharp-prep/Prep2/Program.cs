using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string GradeInText = Console.ReadLine();
        int Grade = int.Parse(GradeInText);

        string letter = "";

        if (Grade >= 90)
        {
            letter = "A";
        }
        else if (Grade >= 80)
        {
            letter = "B";
        }
        else if (Grade >= 70)
        {
            letter = "C";
        }
        else if (Grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter is: {letter}");

        if (Grade >= 70)
        {
            Console.WriteLine("Congrats you passed!");
        }
        else
        {
            Console.WriteLine("Sorry you failed, better luck next time.");
        }


    }
}