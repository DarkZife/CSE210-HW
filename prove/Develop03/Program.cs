using System;
using System.Collections.Generic;

/*
This will start the program, it will get and display our random scripture.
Next it will look for user input whether it be: Pressing Enter, or typing quit. Enter will continue untill all words hidden, quit will just stop the program.
*/
public class Program
{
    public static void Main()
    {
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture randomScripture = library.GetRandomScripture();

        while (true)
        {
            randomScripture.Display();

            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            bool Hidden = randomScripture.HideWords(2); //This calls to hide words, if there are still words to hide
            if (!Hidden)
            {
                break;
            }
        }
    }
}
