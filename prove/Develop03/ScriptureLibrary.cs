using System;
using System.Collections.Generic;

/*
This class we are in a sense making our scripture list/library. We are storing the scripture and reference, which we call for the references in our reference class.
For fun with our constructors in our reference class, we are adding scriptures that have books, booktype(aka Book of Mormon, New Testamnet, Old Testament, etc..), chapters, verses.
as well we are getting the random scripture from here.
*/

public class ScriptureLibrary
{
    private List<Scripture> scriptures;
    private Random random;

    public ScriptureLibrary()
    {
        scriptures = new List<Scripture>();
        random = new Random();
        Library();
    }

    private void Library()
    {
        Reference reference1 = new Reference("John", 3, 16);
        Scripture scripture1 = new Scripture(reference1, "For God so loved the world, that he gave his only begotten Son, that whosoever believth in him should not perish, but have everlasting life.");
        scriptures.Add(scripture1);

        Reference reference2 = new Reference("New Testament", "Matthew", 22, 37, 38);
        Scripture scripture2 = new Scripture(reference2, "Jesus said unto him, Thou shalt love the Lord thy God with all thy heart, and with all they soul, and with all thy mind. This is the first and great commandment.");
        scriptures.Add(scripture2);

        Reference reference3 = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture3 = new Scripture(reference3, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths.");
        scriptures.Add(scripture3);

        Reference reference4 = new Reference("New Testament", "John", 14, 27);
        Scripture scripture4 = new Scripture(reference4, "Peace I leave with youm my peace I give unto you: not as the world giveth, give I unto you. Let not your heart be troubled, neither let it be afraid.");
        scriptures.Add(scripture4);

        Reference reference5 = new Reference("Matthew", 22, 39);
        Scripture scripture5 = new Scripture(reference5, "And the second is like unto it, Thou shalt love thy neighbour as thyself.");
        scriptures.Add(scripture5);

        Reference reference6 = new Reference("Doctrine and Covenants", "D&C", 42, 29);
        Scripture scripture6 = new Scripture(reference6, "If thou lovest me thou shalt serve me and keep all my commandments.");
        scriptures.Add(scripture6);


    }

    public Scripture GetRandomScripture()
    {
        int index = random.Next(scriptures.Count);
        return scriptures[index];
    }
}