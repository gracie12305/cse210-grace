using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;


public class Scripture
{
    private string  _reference;
    private string _text;
    
    private List<string>_words = new List<string>();
    private string IsHidden;


    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        IsHidden = "";
    }

    public void HideRandomWords(int numbersToHide)
    {
        numbersToHide = IsHidden;
        Random rand = new Random();
        int index;
        do
        {
            index = rand.Next(_words.Count);
        }
        while (_words[index].IsHidden); // Ensure the word is not already hidden

        _words[index].IsHide(); // Hide the selected word
    }

    public string GetDisplayText()
    {
        return IsHidden ? new string('_', _text.Length) : _text;
    }

}                                          

   









