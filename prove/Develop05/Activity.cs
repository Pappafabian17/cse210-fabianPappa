public class Activity
{
  private string _name;
  private string _description;
  private int _duration;

  public Activity(string name, string description)
  {
    _name = name;
    _description = description;
    
  }

  public int GetDuration()
  {
    return _duration;
  }

  public void DisplayStartingMessage()
  {
    Console.WriteLine($"Starting {_name}.");
    Console.WriteLine(_description);
    Console.WriteLine("How many time in seconds do you want to do this activity?");
    _duration = int.Parse(Console.ReadLine());
    Console.WriteLine("Let's get started...");
    ShowSpinner(3);
  }
  public void DisplayEndingMessage()
  {
    Console.WriteLine("Good Job!!");
    Console.WriteLine($"You have completet {_name} in {_duration} seconds!");
    ShowSpinner(3);

  }

  public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < futureTime)
        {
            Console.Write("/\r");
            Thread.Sleep(500);
            Console.Write("-\r");
            Thread.Sleep(500);
        }
    }
  public void ShowCountDown(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < futureTime)
        {
            TimeSpan timeLeft = futureTime - DateTime.Now;
            Console.WriteLine($"{timeLeft.Seconds} seconds remaining...");
            Thread.Sleep(1000);
        }
    }


}