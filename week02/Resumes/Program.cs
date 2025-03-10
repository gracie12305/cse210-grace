using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!.");
        Job job1 = new Job();
        job1._Jobtitle = "Software engineer";
        job1._company = "Amazone";
        job1._startYear = 2020;
        job1._endYear = 2022;


        Job job2 = new Job();
        
        job2._Jobtitle = "web programmer";
        job2._company = "Google";
        job2.Display();
        job2._startYear = 2022;
        job2._endYear = 2025;

        Resume myResume = new Resume();
        myResume._name = "Amma Bossman";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}