using System;

public class ListingActivity : MindfulnessActivity
{
    private string[] prompts =
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public override void StartActivity()
    {
        StartMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.Clear();
        Console.WriteLine(prompt);
        
        ShowPauseAnimation(3);  // Wait for the user to begin thinking

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine("Please list something:");
            string item = Console.ReadLine();
            count++;
            ShowPauseAnimation(1);  // Small pause after each entry
        }

        Console.Clear();
        Console.WriteLine($"You listed {count} items.");
        FinishMessage("Listing");
    }
}