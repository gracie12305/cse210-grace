using System;

public class Comment
{
    public string _commentername;
    public string _text;

    public Comment(string commentername, string text)
    {
        _commentername = commentername;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_commentername}:  {_text}");
    }
}