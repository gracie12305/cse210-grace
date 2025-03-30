using System;

public class Word
{
    private string ScriptureReference;
    private string _text;
    private bool _isHidden;
    List<Word> words = new List<Word>();

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _text = "";
        _isHidden = true;
    }

    public void Show()
    {
        Console.WriteLine($"Scripture Reference: {ScriptureReference}");
        Console.WriteLine("Scripture Text:");
    }

    public bool IsHidden()
         {
            
        foreach (Word word in words)
        {
            if (!word._isHidden)
                return false;
        }
        return true;
    }
    public string GetDisplay()
    {
        string text = $"{_text}";
        return text;
    }
}