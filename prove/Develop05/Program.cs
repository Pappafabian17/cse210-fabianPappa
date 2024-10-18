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
            Console.WriteLine("4. Family Activity");
            Console.WriteLine("5. Quit");
            string selection = Console.ReadLine();

            switch(selection)
            {
                case "1":
                    BreathingActivity breathingActiv = new BreathingActivity();
                    breathingActiv.Run();
                    break;

                case "2":
                ReflectionActivity reflectionActiv = new ReflectionActivity();
                reflectionActiv.Run();
                break;
                case "3":
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                break;

                case "4":
                    FamilyActivity familyActivity = new FamilyActivity();
                    familyActivity.Run();
                    break;

                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }

        } 
    }
}