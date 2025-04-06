using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        bool running = true;
        while (running)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness App!");
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Enter the number of your choice: ");
            string choice = Console.ReadLine();

            MindfulnessActivity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    running = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice, please select again.");
                    Thread.Sleep(2000);
                    continue;
            }

            if (activity != null)
            {
                activity.StartActivity();
            }
        }
    }
}