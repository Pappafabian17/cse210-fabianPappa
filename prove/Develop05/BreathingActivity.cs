public class BreathingActivity : Activity
{
public BreathingActivity(): base("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
{

}
public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        int interval = 3;

        while (DateTime.Now < futureTime)
        {
            Console.Clear();
            Console.WriteLine("Breathe in...");
            ShowCountDown(interval);

            if (DateTime.Now < futureTime)
            {
                Console.Clear();
                Console.WriteLine("Breathe out...");
                ShowCountDown(interval);
            }
        }

        DisplayEndingMessage();
    }
}