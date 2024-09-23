using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "replace";
        job1._jobTitle = "Frontend Developer";
        job1._startYear = 2022;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Jade";
        job2._jobTitle = "Seller";
        job2._startYear = 2020;
        job2._endYear = 2022;
        job2.Display();

        Resume personalResume = new Resume();
        personalResume._name = "Fabian Pappa";
        personalResume._jobs.Add(job1);
        personalResume._jobs.Add(job2);

        personalResume.Display();
    }
}