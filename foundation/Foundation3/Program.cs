using System;

class Program
{
    static void Main(string[] args)
    {
        Activity swimming = new Swimming(new DateTime(2024, 10, 26), 25, 20); 
        Activity running = new Running(new DateTime(2024, 10, 27), 30, 4.8);  
        Activity cycling = new Cycling(new DateTime(2024, 10, 28), 40, 20.0); 
        Activity swimming2 = new Swimming(new DateTime(2024, 10, 29), 38, 27); 
        Activity cycling2 = new Cycling(new DateTime(2024, 10, 30), 22, 33); 
        Activity running2 = new Running(new DateTime(2024, 10, 31), 41, 4.2);  

        List<Activity> activities = new List<Activity>();
        activities.Add(swimming);
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming2);
        activities.Add(cycling2);
        activities.Add(running2);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}