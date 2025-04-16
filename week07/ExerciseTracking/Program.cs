using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        
        Activity run = new Running("23 March 2025", 38, 3.8);
        Activity cycle = new Cycling("6 April 2025", 100, 12.9);
        Activity swim = new Swimming("20 April 2025",67, 10);
        
        List<Activity> activities = new List<Activity> {run, cycle, swim};


        foreach (Activity act in activities)
        {
            Console.WriteLine(act.GetSummary());
        }
    }

}