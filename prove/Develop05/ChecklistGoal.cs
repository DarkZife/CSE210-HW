using System;

public class ChecklistGoal : Activity
{
    private int completionCount;
    private int targetCount;
    private int bonusValue;

    public ChecklistGoal(string name, int value, int targetCount, int bonusValue) : base(name, value)
    {
        this.completionCount = 0;
        this.targetCount = targetCount;
        this.bonusValue = bonusValue;
    }

    public override void Complete()
    {
        completionCount++;
        Console.WriteLine($"Goal '{name}' completed {completionCount}/{targetCount} times! You gained {value} points.");
        if (completionCount == targetCount)
        {
            Console.WriteLine($"Congratulations! You achieved the desired amount and received a bonus of {bonusValue} points.");
        }
    }

    public override string GetStatus()
    {
        return $"CG Completed {completionCount}/{targetCount} times - {name}";
    }
}