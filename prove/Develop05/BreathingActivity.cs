public class BreathingActivity : Activity
{
public BreathingActivity(): base("Breathing Activity","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
{

}
public void Run()
{
  DisplayStartingMessage();
  
  int secondsPassed = 0;
        while (secondsPassed < _duration)
        {
            Console.WriteLine("Breath in");
            ShowCountDown(3);  
            secondsPassed += 3;

            if (secondsPassed < _duration)
            {
                Console.WriteLine("Breath out ");
                ShowCountDown(3);  
                secondsPassed += 3;
            }
        }
        DisplayEndingMessage();
}

}