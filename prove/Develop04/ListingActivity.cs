using System;


//Listing good things in your life, to uplift your mood.


class ListingActivity : Activity
{
    private string[] prompts = {
        "What are you favorite places to vist?",
        "What do you like to do in your free time?",
        "What are your favorite hobbies?",
        "What are your favorite books?",
        "What do you like to eat?"
    };

    public ListingActivity()
    {
        name = "Listing Activity";
        description = "This activity will help you list the good things in your life.";
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("Starting listing activity...");
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        ShowCountdown();
        Console.WriteLine("Keep listing items:");
        ShowSpinner();

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int itemCount = 0;
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            itemCount++;
            ShowSpinner();
        }

        Console.WriteLine("Number of items listed: " + itemCount);
    }

    private void ShowCountdown()
    {
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    private void ShowSpinner()
    {
        char[] spinner = { '<', '^', '>', '-' };
        foreach (char c in spinner)
        {
            Console.Write(c + "\r");
            Thread.Sleep(100);
        }
    }
}