public class Swimming : Activity
{
  private int _laps;
  private const double LapLengthKm = 0.05; 

  public Swimming(DateTime date, int durationInMinutes, int laps) : base(date, durationInMinutes)
  {
    _laps = laps;
  }

  public override double GetDistance() 
  {
    return  _laps * LapLengthKm;
  }

  public override double GetSpeed() 
  {
    return (GetDistance() / GetDurationInMinutes()) * 60;
  }

  public override double GetPace() {
    return  GetDurationInMinutes() / GetDistance();
  }
}