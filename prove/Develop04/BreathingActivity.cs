using System;


// Breathing activity to focus on breathing and relax.
class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        name = "Breathing Activity";
        description = "This activity will help you relax and focus on your breathing.";
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("Starting breathing activity...");
        for (int i = 0; i < duration; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine("Breathe in...");
            else
                Console.WriteLine("Breathe out...");
            ShowSpinner();
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