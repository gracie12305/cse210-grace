using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

    Console.Write("Would you like to write down a scripture? Please enter or quite to stop");

    
    {
        string scriptureReference = "Proverbs 3:5-6";
        string scriptureText = "Trust in the Lord with all your heart and lean not on your own understanding. In all your ways acknowledge Him, and He will make your paths straight.";
        
        // Splitting the scripture text into words
        List<string> words = new List<string>(scriptureText.Split(' '));
        List<string> hiddenWords = new List<string>(); 
        
        // Display initial scripture
        DisplayScripture(scriptureReference, scriptureText, hiddenWords);

        // using the loop for user prompt
        while (true)
        {
            Console.WriteLine("\nPress Enter to hide a random word, or type 'quit' to exit.");
            Console.Write("Would you like to write down a scripture? Please enter or quite to exit");
            

            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else if (userInput == "")
            {
                // Hide a random word
                HideRandomWord(words, hiddenWords);
                DisplayScripture(scriptureReference, scriptureText, hiddenWords);

                // If all words are hidden, the program should end
                if (hiddenWords.Count == words.Count)
                {
                    Console.WriteLine("\nAll your words are hidden, Thank You.....goodbye!!");
                    break;
                }
            }
        }
    }

    // Display the scripture with hidden words
    static void DisplayScripture(string reference, string text, List<string> hiddenWords)
    {
        Console.Clear();
        Console.WriteLine($"Scripture Reference: {reference}");
        Console.WriteLine("Scripture Text:");

        // Split the text into words and display each word
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            if (hiddenWords.Contains(word)) // Display underscores for hidden words
            {
                Console.Write(new string('_', word.Length) + " ");
            }
            else // Otherwise, display the word itself
            {
                Console.Write(word + " ");
            }
        }
        Console.WriteLine();
        }

    // hiding a random word from the scripture
    static void HideRandomWord(List<string> words, List<string> hiddenWords)
    {
        Random rand = new Random();
        
        // Find a random word that has not been hidden yet
        string wordToHide;
        do
        {
            int index = rand.Next(words.Count);
            wordToHide = words[index];
        } while (hiddenWords.Contains(wordToHide)); // Ensure it's not already hidden
        
        hiddenWords.Add(wordToHide); // Mark the word as hidden
    }
}
}  

   