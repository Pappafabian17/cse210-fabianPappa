using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void CreateGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            goal.RecordEvent();

            if (goal is SimpleGoal && goal.IsComplete())
            {
                _score += goal.GetPoints();  
            }
            else if (goal is EternalGoal)
            {
                _score += goal.GetPoints();  
            }
            else if (goal is ChecklistGoal checklistGoal)
            {
                if (checklistGoal.IsComplete())
                {
                    _score += checklistGoal.GetBonus(); 
                }
                _score += goal.GetPoints();  
            }
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStringRepresentation()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Your current score is: {_score} points.");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        _goals.Clear(); 
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',');

            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]); 

            if (goalType == "SimpleGoal")
            {
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal goal = new SimpleGoal(name, description, points); 
                if (isComplete) goal.RecordEvent(); 
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(name, description, points); 
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                int target = int.Parse(parts[4]);
                int amountCompleted = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus); 
                for (int j = 0; j < amountCompleted; j++)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
        }
    }
}
