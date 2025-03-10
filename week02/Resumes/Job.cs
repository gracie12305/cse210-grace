using System;

public class Job
    {
        
        public string _company;
        public string _Jobtitle ="";
        public int _startYear;
        public int _endYear;

        //A method that displays the message
        public Job()
        {
            Console.WriteLine($"{_company} {_Jobtitle} {_startYear}-{_endYear}.");
        }
        
        Job job = new Job();
        
        
    }
     
