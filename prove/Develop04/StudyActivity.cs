using System;


// I added this activity just for fun, and I needed to study for my midterm as well, so thats why this activity is here.
class StudyActivity : Activity
{
     public string subject = "Discov/Discern Through Arts Study";

    private string[] questions = {
        "How did Shakespeare adapt the story of Macbeth to suit the tastes of James I, King of England?",
        "Is Macbeth a reliable history of the event in the history of Scotland?",
        "What is blank verse?",
        "Who is the king of Scotland at the beginning of the play?",
        "Who are his two generals?",
        "What makes Banquo doubt that the witches are women?",
        "How did Macbeth get to be Thane of Cawdor?",
        "Of whom does Malcolm say, 'Nothing in his life Became him like the leaving it?'",
        "When Macbeth hesitates, how does Lady Macbeth persuade him to go through with the awful deed?",
        "Before the murder, Macbeth sees a vision. What is it of?",
        "Who says 'Double double toil and trouble'?",
        "Who do the witches tell Macbeth to beware of?",
        "How does Macbeth punish Macduff for fleeing to England?"

    };

    public StudyActivity()
    {
        name = "Study Activity";
        description = "This activity will help you study for exams(you have to input your own questions in the program itself).";
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("Starting Study activity...");
        Console.WriteLine(subject);
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