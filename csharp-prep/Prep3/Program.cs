using System;

class Program
{
    static void Main(string[] args)
    {

        string response = "yes";

        while (response == "yes")
        {
            Random randomGenerator = new Random();
            int magNum = randomGenerator.Next(1, 100);

            int num = -1;
            int guess = 0;


            while (num != magNum)
            {

                Console.WriteLine("What is your guess? ");
                num =int.Parse( Console.ReadLine());

                guess += 1;

                if (num == magNum)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"Number of guesses {guess}");
                }
                else if (num < magNum)
                {
                    Console.WriteLine("Higher");
                }      
                else
                {
                    Console.WriteLine("Lower");
                }
            }
         
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        }         
    }

}