using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected int duration;

    public abstract void StartActivity();
    
    // Common start message for all activities
    protected void StartMessage(string activityName, string description)
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {activityName}!");
        Console.WriteLine(description);
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin!");
        Thread.Sleep(2000);  // Simulate a small pause before starting
    }

    // Common finish message for all activities
    protected void FinishMessage(string activityName)
    {
        Console.Clear();
        Console.WriteLine($"Well done! You've completed the {activityName} activity.");
        Console.WriteLine($"Duration: {duration} seconds.");
        Thread.Sleep(2000);  // Pause to let the user reflect on their success
    }

    // Pauses the program and shows an animation (spinner or countdown)
    protected void ShowPauseAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);  // Simulate 1 second pause with a dot animation
        }
    }
}