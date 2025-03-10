using System

public class Resume
{
    public string _name;
    public List<Job>_jobs = new List<Job>();

    public void Display()
    {
        //enter your name
        Console.WriteLine($"Name : {_name}");
        Console.WriteLine("Jobs:");
        
        {
            Job.Display();

            Resume Resume = new Resume();

            Job job1 = new Job();
            Job job2 = new Job();

            Resume._jobs.Add(job1);
        }
    }
}