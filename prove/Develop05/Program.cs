using System;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            string selection = Console.ReadLine();

            switch(selection)
            {
                case "1":
                    BreathingActivity breathingActiv = new BreathingActivity();
                    breathingActiv.Run();
                    break;

                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }

        } 
    }
}