using System;
using System.Data;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;


public class Scripture
{
    private string  ScriptureReference;
    private string _text;
    
    private List<string>_words = new List<string>();



    public void HideRandomWords(int numbersToHide)
    {

        Random rand = new Random();
    }
    public string GetDisplayText()
    {
        return ScriptureReference;
    }

}                                          

   









