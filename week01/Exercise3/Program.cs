using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the guesing game.");

        //Console.Write("What is your magic guessing number?");
        //int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,200);

        int guess = -1;

        while (guess != magicNumber)
        {
           Console.Write("What is your magic guessing number?"); 
           guess = int.Parse(Console.ReadLine());
        
        

            if (magicNumber > guess)
            {
                Console.Write("Higher");
            }
            else if (magicNumber < guess)
            {
            Console.Write("Lower");  
            }
            else
            {
            Console.Write("Good job, you have guessed it"); 
            }
        }
            

    }
}