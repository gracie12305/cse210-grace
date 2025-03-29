using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;


public class Scripture
{
    private string  _reference;
    
    private List<string>_words = new List<string>();
    private string IsHidden;


    public Scripture(Reference reference, string text)
    {
        _reference = Reference;
        text = Text;
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

        _words[index].Hide(); // Hide the selected word
    }

    public string GetDisplayText()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }

}                                          

   









