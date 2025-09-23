using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "MD Landscaping";
        job1._jobTitle = "Lawn Tech";
        job1._startYear = 2025;
        job1._endYear = 2025;

        Job job2 = new Job();

        job2._company = "EcoDry";
        job2._jobTitle = "Demo Tech";
        job2._startYear = 2024;
        job2._endYear = 2025;

        // job1.DisplayJobDetails();
        // job2.DisplayJobDetails();

        Resume myResume = new Resume();

        myResume._name = "Brandon Garrett";
        myResume._job.Add(job1);
        myResume._job.Add(job2);

        myResume.DisplayResume();
    }
     
}