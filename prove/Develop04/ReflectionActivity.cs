using System;


//Just like the listing activity, purpose is to uplift your mood in a different way/ reflect on your past.


class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time of your favorite memory.",
        "Think of a time of your proudest moment.",
        "Think of a time when you overcame a tough challenge",
        "Think of what matters most in your life"
    };

    private string[] questions = {
        "Why is this experience meaningful to you?",
        "How did this experience effect you?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity()
    {
        name = "Reflection Activity";
        description = "This activity will help you reflect on times in your life";
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("Starting reflection activity...");
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        ShowSpinner();
        Thread.Sleep(3000);

        foreach (string question in questions)
        {
            Console.WriteLine(question);
            ShowSpinner();
            Thread.Sleep(3000);
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