using System;

class Program
{
    static void Main(string[] args)
    {
        
        DisplayWelcome();
        PromptUserName();
        string userName = Console.ReadLine();
        int num = PromptUserNumber();
        int sqrNum = SquareNumber(num);

        DisplayResults(userName, sqrNum);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");

    }
    
    static void PromptUserName()
    {
        Console.WriteLine("Enter in your user name: ");
        

    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Enter in a number: ");
        int num = int.Parse(Console.ReadLine());

        return num;
    }

    static int SquareNumber(int num)
    {

        int squared = num * num;

        return squared;

    }

    static void DisplayResults(string name, int sqrNum)
    {
        Console.WriteLine($"{name}, the square of your number is {sqrNum}.");
    }


}