public class SimpleGoal : Goal{
  protected bool _isComplete;

  public SimpleGoal(string name, string description, int points) : base(name, description, points)
  {
    _isComplete = false;
  }
  public override void RecordEvent()
  {
    _isComplete = true;
    Console.WriteLine($"You have completed the goal: {_shortName} and earned {_points} points!");
  }
  public override bool IsComplete()
  {
    return _isComplete;
  }
  public override string GetStringRepresentation()
  {
    return $"[ {(IsComplete() ? "X" : " ")} ] {_shortName} - {_points} points";
  }
}