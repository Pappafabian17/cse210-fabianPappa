using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option (1-6): ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateNewGoal(goalManager);
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    break;
                case "3":
                    SaveGoals(goalManager);
                    break;
                case "4":
                    LoadGoals(goalManager);
                    break;
                case "5":
                    RecordEvent(goalManager);
                    break;
                case "6":
                    quit = true;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a number between 1 and 6.");
                    break;
            }
        }
    }

    public static void CreateNewGoal(GoalManager goalManager)
    {
        Console.WriteLine("\nChoose the type of goal to create:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select an option (1-3): ");

        string choice = Console.ReadLine();
        Goal newGoal = null;

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for the goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("Enter the target amount to complete the goal: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points upon completion: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type. Please choose a valid option.");
                return;
        }

        goalManager.CreateGoal(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    public static void SaveGoals(GoalManager goalManager)
    {
        Console.Write("Enter the filename to save the goals: ");
        string filename = Console.ReadLine();
        goalManager.SaveGoals(filename);
        Console.WriteLine($"Goals saved to {filename}.");
    }

    public static void LoadGoals(GoalManager goalManager)
    {
        Console.Write("Enter the filename to load the goals: ");
        string filename = Console.ReadLine();
        goalManager.LoadGoals(filename);
        Console.WriteLine($"Goals loaded from {filename}.");
    }
    public static void RecordEvent(GoalManager goalManager)
    {
        goalManager.DisplayGoals();
        Console.Write("Enter the number of the goal you want to record an event for: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        goalManager.RecordEvent(goalIndex);
        Console.WriteLine("Event recorded successfully.");
        goalManager.DisplayScore();
    }
}
