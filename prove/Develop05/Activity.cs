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
    for(int i = 0 ; i < seconds ; i++)
    {
      Console.Write("/\r");
            System.Threading.Thread.Sleep(500);
            Console.Write("-\r");
            System.Threading.Thread.Sleep(500);
    }
  }
  public void ShowCountDown(int seconds)
  {
    for(int i = seconds ; i > 0 ; i-- )
    {
      Console.WriteLine(i);
      System.Threading.Thread.Sleep(1000);
    }
  }

}