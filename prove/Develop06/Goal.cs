public abstract class Goal{
  protected string _shortName;
  protected string _description;
  protected int _points ;

  public Goal(string name, string description, int points){
    _shortName = name;
    _description = description;
    _points = points;
  }

public int GetPoints()
{
  return _points;
}
  public abstract void RecordEvent();
  public abstract bool IsComplete();
  public abstract string GetStringRepresentation();

  public string GetDetailString()
  {
    return $"{_shortName}: {_description} - {_points} points";
  }

}