public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        Random random = new Random();

        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine("Consider the following prompt and start listing items:");
        Console.WriteLine(prompt);
        ShowSpinner(3);

        List<string> items = new List<string>();

        
        while (DateTime.Now < futureTime)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            items.Add(item);

            
            if (DateTime.Now >= futureTime)
            {
                Console.WriteLine("Time's up!");
                break;
            }
        }

        
        Console.WriteLine($"You listed {items.Count} items:");
        foreach (string item in items)
        {
            Console.WriteLine($"- {item}");
        }

        DisplayEndingMessage();
    }
}