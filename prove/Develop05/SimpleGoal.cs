using System;

public class SimpleGoal : Activity
{
    public SimpleGoal(string name, int value) : base(name, value) { }

    public override void Complete()
    {
        Console.WriteLine($"Goal '{name}' completed! You gained {value} points.");
    }

    public override string GetStatus()
    {
        return $"SG {name}";
    }
}