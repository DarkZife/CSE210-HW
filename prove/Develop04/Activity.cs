using System;


// this is to show that the program is starting, and gathers the duration time, prepare message, finish message, preform.

abstract class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public void Start()
    {
        Console.WriteLine("Starting " + name);
        Console.WriteLine(description);
        GetDuration();
        PrepareToBegin();
        PerformActivity();
        Finish();
    }

    protected void GetDuration()
    {
        while (true)
        {
            Console.Write("Enter duration in seconds: ");
            if (int.TryParse(Console.ReadLine(), out int input) && input > 0)
            {
                duration = input;
                break;
            }
            Console.WriteLine("Duration must be a positive number.");
        }
    }

    protected void PrepareToBegin()
    {
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000);
    }

    protected void Finish()
    {
        Console.WriteLine("Good job! You have completed " + name + " for " + duration + " seconds.");
        Thread.Sleep(3000);
        Console.WriteLine();
    }

    protected abstract void PerformActivity();
}