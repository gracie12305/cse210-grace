using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to this program.");
    

    
        Console.Write("Please enter your name:");
        string name = Console.ReadLine();
    

        Console.Write("Please enter your favourite number:");
        int userNumber = int.Parse(Console.ReadLine());

        
        int square = userNumber * userNumber;

        Console.WriteLine($"{name}, the suare of your number is {square}");


    }


}
