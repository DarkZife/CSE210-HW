using System;
using System.Collections.Generic;


//This is just storing the actual words in the scriptures, and then determins if a word is visible or not.



public class Word
{
    public string Text { get; }
    public bool Hidden { get; set; }

    public Word(string text)
    {
        Text = text;
        Hidden = false;
    }
}