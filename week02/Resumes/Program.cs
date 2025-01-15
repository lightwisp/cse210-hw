using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Jr. Dev";
        job1._startYear = 2019;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Intern";
        job2._startYear = 2020;
        job2._endYear = 2025;

        Resume resume = new Resume();
        resume._jobs.Add(job1); 
        resume._jobs.Add(job2); 

        resume.ReturnResume();
        
    }
}


