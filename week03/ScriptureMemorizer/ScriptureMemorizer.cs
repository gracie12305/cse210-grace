using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Transactions;


public class Scripture
{
    private string  _reference;
    
    private List<string>_words = new List<string>();


    public Scripture(Reference ref, string text)
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

}                                          

   









