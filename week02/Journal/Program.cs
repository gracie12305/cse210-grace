using System;
using System.Globalization;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

public class Journalize
{
    static void Main(string[] args)

    {

        Console.WriteLine("Welcome to your Journal, this is your daily event recorder journal.");

        string currentDate = DateTime.Now .ToString("yyy-mm-dd");

        //ask the user for a file  name
        Console.Write("What would you like to name your file?");
        string filename = Console.ReadLine();
        Console.WriteLine($"Your filename is {filename}.txt");

        using(StreamWriter write = File.AppendText(filename))



        {
            while (true)
            {
                Console.WriteLine("Please select from the list bellow:");

                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");

                Console.Write("What would you like to do today?");

                int choice = Convert.ToInt32 (Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("Who was the most interesting person I interected with today?");
                    
                    Console.Write("What was the best part of my day?");

                    Console.Write("How did I see the hand of the Lord in my life today?");

                    Console.Write("What was the strongest emotion I felt today?");

                    Console.Write("If I had one thing I couldmdo over yoday, what would it be?");

                    Console.Write("What am I grateful for today?");

                    Console.Write("If I have anything to give to the needy, what would it be?");

                    Console.Write("In what why didi i shoe gratitude ");

                }

                else if (choice == 2)
                {
                    Console.ReadLine();
                }


                else if (choice == 3)
                {
                    Console.WriteLine("Saving to file...");
                    filename = Console.ReadLine();
                    using(StreamWriter ouputfile = new StreamWriter (filename))
                    {
                        ouputfile.WriteLine();
                    }
                }

                else 
                {
                    Console.WriteLine("Thankyou, Goodbye!!");
                }
            }

        

        }


    }
}