using System;

public class BreathingActivity : MindfulnessActivity
{
    public override void StartActivity()
    {
        StartMessage("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.WriteLine("Breathe in...");
            ShowPauseAnimation(3);  // Wait for 3 seconds
            Console.Clear();
            Console.WriteLine("Breathe out...");
            ShowPauseAnimation(3);  // Wait for 3 seconds
        }

        FinishMessage("Breathing");
    }
}