using System;
using System.Collections.Generic;

// Main program
public class Program
{
    private static List<Activity> goals = new List<Activity>();
    private static int score = 0;

    public static void Main(string[] args)
    {
        // Sample data
        goals.Add(new SimpleGoal("Run a marathon", 1000));
        goals.Add(new EternalGoal("Read scriptures", 100));
        goals.Add(new ChecklistGoal("Attend the temple", 50, 10, 500));

        while (true)
        {
            Console.WriteLine("\n1. Display score");
            Console.WriteLine("2. Create new goal");
            Console.WriteLine("3. Record an event");
            Console.WriteLine("4. Show list of goals");
            Console.WriteLine("5. Exit");

            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();
            Console.WriteLine();
            
            switch (choice)
            {
                case "1":
                    DisplayScore();
                    break;
                case "2":
                    CreateGoal();
                    break;
                case "3":
                    RecordEvent();
                    break;
                case "4":
                    ShowGoalList();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void DisplayScore()
    {
        Console.WriteLine($"Current score: {score} points");
    }

    private static void CreateGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal type (simple/eternal/checklist): ");
        string type = Console.ReadLine();

        Console.Write("Enter goal value: ");
        int value = Convert.ToInt32(Console.ReadLine());

        if (type == "simple")
        {
            goals.Add(new SimpleGoal(name, value));
        }
        else if (type == "eternal")
        {
            goals.Add(new EternalGoal(name, value));
        }
        else if (type == "checklist")
        {
            Console.Write("Enter target count: ");
            int targetCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter bonus value: ");
            int bonusValue = Convert.ToInt32(Console.ReadLine());

            goals.Add(new ChecklistGoal(name, value, targetCount, bonusValue));
        }
        else
        {
            Console.WriteLine("Invalid goal type. Please try again.");
        }
    }

    private static void RecordEvent()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Activity goal = goals.Find(g => g.GetName() == name);
        if (goal != null)
        {
            goal.Complete();
            score += goal.Value;
        }
        else
        {
            Console.WriteLine("Goal not found. Please try again.");
        }
    }

    private static void ShowGoalList()
    {
        Console.WriteLine("List of goals:");
        foreach (Activity goal in goals)
        {
            Console.WriteLine($"{goal.GetStatus()}");
        }
    }
}
