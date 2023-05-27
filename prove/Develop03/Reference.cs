using System;
using System.Collections.Generic;

/*
Here we get our references from our scripture library class and formatting it how we want, depending on what all is sent.
As you can see below we have 4 if statements looking to see if it has a Type of book(Book of Mormon, Bible, or New Testament, Old Testament, etc..), Book, chapter, and how many verses(wheter its just one or many).
After it determins what if statement is in a sense "correct", We just format it from there.
*/





public class Reference
{
    public string TypeOfBook { get; }
    public string Book { get; }
    public int Chapter { get; }
    public int StartVerse { get; }
    public int EndVerse { get; }
    

    public Reference(string typeofbook,string book, int chapter, int startVerse, int endVerse)
    {
        TypeOfBook = typeofbook;
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public Reference(string typeofbook,string book, int chapter, int verse)
    {
        TypeOfBook = typeofbook;
        Book = book;
        Chapter = chapter;
        StartVerse = verse;
        EndVerse = verse;
    }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = verse;
        EndVerse = verse;
    }

    public string GetFormat()
    {
        if (StartVerse == EndVerse && TypeOfBook == null)
        {
            return $"{Book} {Chapter}:{StartVerse}";
        }
        else if (TypeOfBook == null)
        {
            return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
        }
        else if (StartVerse == EndVerse)
        {
            return $"{TypeOfBook}: {Book} {Chapter}: {StartVerse}";
        }
        else
        {
            return $"{TypeOfBook}: {Book} {Chapter}: {StartVerse}-{EndVerse}";
        }
    
    }
}