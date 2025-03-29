using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;


public class Scripture
{
    private string  Reference;
    private string _text;
    
    private List<string>_words = new List<string>();


    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        _text = text;
    }

    public void HideRandomWords(int numbersToHide)
    {

        Random rand = new Random();
        int index;
    }
    public string GetDisplayText()
    {
        return Reference;
    }

}                                          

   









