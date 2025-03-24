using System.Security.Cryptography.X509Certificates;
using system;


public class Fraction
{

    private int _top;
    private int _bottom;

    public Fraction()
    {
        // make the fraction 3/6
        _top = 3;
        _bottom = 6;

    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 6;
    }

    public Fraction(int top , int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        //This is to get the fraction, putted together helps with the division sign
        string text = $"{_top}/{_bottom}";

        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

    


}



