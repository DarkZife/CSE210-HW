using System;
using System.Collections.Generic;

/*
Here we are seperating the reference and the scripture, then displaying hidden words, and looking through to hide unique words(so not the same word twice)
and if all words ard hidden, it will send that to the main program and end it for finishing.
*/

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();

        string[] textWords = text.Split(' ');
        foreach (string word in textWords)
        {
            words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(reference.GetFormat());
        foreach (Word word in words)
        {
            Console.Write(word.Hidden ? "___ " : word.Text + " ");
        }
        Console.WriteLine("\n");
    }

    public bool HideWords(int count)
    {
        List<Word> visibleWords = words.FindAll(word => !word.Hidden);
        if (visibleWords.Count == 0)
        {
            return false; // All words are hidden
        }

        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            if (visibleWords.Count == 0)
            {
                break; // No more visible words
            }

            Word wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hidden = true;
            visibleWords.Remove(wordToHide);
        }

        return true;
    }
}