using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Transactions;


public class Scripture
{
    private Reference _reference;
    
    private List<string>_words = new List<string>();


public Scripture(Reference, string text);
{
    public string Reference;
    public string _text;

}

public void HideRandomWords(int numbersToHide)
{
    Random rand = new Random();
        int index;
        do
        {
            index = rand.Next(Words.Count);
        }
        while (Words[index].IsHidden); // Ensure the word is not already hidden

        Words[index].Hide(); // Hide the selected word
}

public string GetDisplayText()
{
    return IsHidden ? new string('_', Text.Length) : Text;
}

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _text = "";
        IsHidden = true;
    }

    public void Show()
    {
        Console.WriteLine($"Scripture Reference: {Reference.Reference}");
        Console.WriteLine("Scripture Text:");
    }

    public bool IsHidden()
     {
        foreach (Word word in Words)
        {
            if (!word.IsHidden)
                return false;
        }
        return true;
    }
    public string GetDisplay()
    {
        string text = $"{_text}";
        return text;
    }

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

}
}


