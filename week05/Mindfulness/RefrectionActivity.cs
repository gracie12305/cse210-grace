using System;


public class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions =
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "How can you keep this experience in mind in the future?"
    };

    public override void StartActivity()
    {
        StartMessage("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have.");

        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.Clear();
        Console.WriteLine(prompt);

        ShowPauseAnimation(3);  // Wait for the user to reflect

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            string question = questions[rand.Next(questions.Length)];
            Console.Clear();
            Console.WriteLine(question);
            ShowPauseAnimation(4);  // Wait for the user to reflect on each question
        }

        FinishMessage("Reflection");
    }
}