public class FamilyActivity : Activity
{
    private List<string> _familyPrompts = new List<string>
    {
        "Who in your family has supported you recently?",
        "List some fond memories you have with your family members.",
        "Who in your family has made a positive impact on you?",
        "List family members you appreciate and why.",
        "Who in your family do you look up to and why?"
    };

    public FamilyActivity() : base("Family Activity", "This activity will help you reflect on your family and the people close to you by listing things related to them.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        Random random = new Random();

        string prompt = _familyPrompts[random.Next(_familyPrompts.Count)];
        Console.WriteLine("Consider the following prompt and start listing things about your family:");
        Console.WriteLine(prompt);
        ShowSpinner(3);  

        List<string> familyItems = new List<string>();

        
        while (DateTime.Now < futureTime)
        {
            Console.Write("Enter a family-related item: ");
            string item = Console.ReadLine();
            familyItems.Add(item);
            if (DateTime.Now >= futureTime)
            {
                Console.WriteLine("Time's up!");
                break;
            }
        }
        Console.WriteLine($"You listed {familyItems.Count} family-related items:");
        foreach (string item in familyItems)
        {
            Console.WriteLine($"- {item}");
        }

        DisplayEndingMessage();
    }
}
