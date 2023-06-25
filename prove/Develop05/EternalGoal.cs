using System;

public class EternalGoal : Activity
{
    public EternalGoal(string name, int value) : base(name, value) { }

    public override void Complete()
    {
        Console.WriteLine($"Goal '{name}' recorded! You gained {value} points.");
    }

    public override string GetStatus()
    {
        return $"EG {name}";
    }
}