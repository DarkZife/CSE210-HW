using System;

class Program
{
    static void Main(string[] args)
    {
        bool runProgram = true;
        
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

        while (runProgram == true)
        {
            DisplayMenu();
            int menu = int.Parse(Console.ReadLine());

            if (menu == 1)
            {
                string prompt = GetRandomPrompt(prompts);
                Console.WriteLine($"{prompt}");
                string input = Console.ReadLine();

                Entry Addentry = new Entry(prompt, input);

                MyJournal.AddEntry(Addentry);


            }
            else if (menu == 2)
            {
                MyJournal.DisplayJournal();
            

            }
            else if (menu == 3)
            {
                Console.WriteLine("Enter a name to save the file: ");
                string saveName = Console.ReadLine();
                MyJournal.Save(saveName);
            
            }
            else if(menu == 4)
            {
                Console.WriteLine("Enter a entry name to load: ");
                string LoadName = Console.ReadLine();
                MyJournal.Load(LoadName);
            

 
            }
            else
            {   
                runProgram = false;
            }
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
    public string Prompt { get; set; }
    public string Input { get; set; }


    public Entry(string prompt, string input)
    {

        Prompt = prompt;
        Input = input;

    }

}





class Journal
{

    List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();

    }

    public void AddEntry(Entry Addentry)
    {
        entries.Add(Addentry);
    }

    public void Save(string SaveName)
    {
        using (StreamWriter write = new StreamWriter(SaveName))
        {
            foreach (Entry Addentry in entries)
            {
                write.WriteLine($"{Addentry.Prompt}|{Addentry.Input}");
            }
        }

    }

    public void Load(string LoadName)
    {
        entries.Clear();
        using(StreamReader read = new StreamReader(LoadName))
        {
            while(!read.EndOfStream)
            {
                string line = read.ReadLine();
                string[] parts = line.Split('|');
                Entry Addentry = new Entry(parts[0], parts[1]);
                
                entries.Add(Addentry);
            }
        }

    }
    
    
    public void DisplayJournal()
    {
        foreach (Entry Addentry in entries)
        {
            Console.WriteLine($"{Addentry.Prompt}");
            Console.WriteLine($"{Addentry.Input}");
            Console.WriteLine();
        }

    }


}