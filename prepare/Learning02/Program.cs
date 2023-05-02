using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobtitle = "Programmer";
        job1._startYear = 2023;
        job1._endYear = 3023;

        Job job2 = new Job();
        job2._company = "Twitch";
        job2._jobtitle = "Streamer";
        job2._startYear = 2018;
        job2._endYear = 2065;

        Job job3 = new Job();
        job3._company = "Nintendo";
        job3._jobtitle = "Pokemon trainer";
        job3._startYear = 1996;
        job3._endYear = 9999;

        Resume resume = new Resume();

        resume._name = "DarkZife";

        resume._job.Add(job1);
        resume._job.Add(job2);
        resume._job.Add(job3);

        resume.Display();

        
    }
}