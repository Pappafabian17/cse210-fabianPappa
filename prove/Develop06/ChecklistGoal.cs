public class ChecklistGoal : Goal
{
    protected int _amountCompleted;
    protected int _target;
    protected int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted < _target)
        {
            Console.WriteLine($"Progress: {_amountCompleted}/{_target} - Earned {_points} points.");
        }
        else if (_amountCompleted == _target)
        {
            Console.WriteLine($"Goal completed! You've earned {_bonus} bonus points!");
        }
    }
    
    public int GetBonus()
{
    return _bonus;
}
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetStringRepresentation()
    {
        return $"[ {(IsComplete() ? "X" : " ")} ] {_shortName} - Completed {_amountCompleted}/{_target} times";
    }
}
