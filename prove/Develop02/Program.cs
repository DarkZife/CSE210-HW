using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be",
            "Whats going on in the world today?",
            "What exciting plans do you have coming up?",
            "What is something new you learned today?",
            "What are the best ways I handle stress?",
            "What are you wanting to do in the future?"
        };

        Journal MyJournal = new Journal();

        static string GetRandomPrompt(List<string> prompts)
        {
            Random random = new Random();
            int i = random.Next(0, prompts.Count);
            return prompts[i];
        }


        DisplayMenu();
        int menu = int.Parse(Console.ReadLine());

        if (menu == 1)
        {
            string prompt = GetRandomPrompt(prompts);
            Console.WriteLine($"{prompt}");
            string entry = Console.ReadLine();
        }
        else if (menu == 2)
        {
            MyJournal.DisplayJournal();
            return;
        }
        else if (menu == 3)
        {
            Console.WriteLine("Enter a name to save the file: ");
            string saveName = Console.ReadLine();
            MyJournal.Save(saveName);
            return;
        }
        else if(menu == 4)
        {
            Console.WriteLine("Enter a entry name to load: ");
            string LoadName = Console.ReadLine();
            MyJournal.Load(LoadName);
            return;
        }
        else
        {
            return;
        }
    
    static void DisplayMenu()
    {
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display journal entries");
        Console.WriteLine("3. Save journal");
        Console.WriteLine("4. Load journal");
        Console.WriteLine("5. Quit");
    
    }
    
    
    
    }


}

class Entry
{


}

class Journal
{

    public Journal()
    {

    }

    public void Save(string SaveName)
    {

    }

    public void Load(string LoadName)
    {

    }
    
    
    public void DisplayJournal()
    {

    }


}