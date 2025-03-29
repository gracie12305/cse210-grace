using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter,int verse)
    {
        _book = "Proverbs";
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse);
    {
        _book = book;
        _cahpter = chapter;
        _startVerse = startVerse;
        _endVerse = endverse;
    }

    public string GetDisplayText()
    {
        Console.WriteLine("Here is your reference, Enjoy");
    }

}



