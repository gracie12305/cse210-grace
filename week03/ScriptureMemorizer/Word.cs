using System;

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
        _isHidden = true;
    }

    public void Show()
    {
        Console.WriteLine($"Scripture Reference: {Reference}");
        Console.WriteLine("Scripture Text:");
    }

    public bool IsHidden()
         {
        foreach (Word word in word)
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