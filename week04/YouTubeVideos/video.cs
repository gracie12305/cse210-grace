using System;


public class Video
{
    public string _title;
    public string _author;
    public int _lenght{get; set;}
    public List<Comment> Comments{get; set;}


    public Video(string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _lenght = lenght;
        Comments =  new List<Comment>();
        
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }


    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"lenght: {_lenght}");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments");
        foreach (var comment in Comments)
        {
            comment.DisplayComment();
        }


    }
}