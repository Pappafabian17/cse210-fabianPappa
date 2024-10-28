using System;
using System.Collections.Generic;
public abstract class Activity
{
  private DateTime _date;
  private int _durationInMinutes;

  public Activity(DateTime date, int durationInMinutes)
  {
    _date = date;
    _durationInMinutes =durationInMinutes;
  }

  public DateTime GetDate()
    {
      return _date;
    }

    public int GetDurationInMinutes()
    {
      return _durationInMinutes;
    }
  public abstract double GetDistance();
  public abstract double GetSpeed();
  public abstract double GetPace();

  public string GetSummary()
  {
        return $"{GetDate().ToString("dd MMM yyyy")} {GetType().Name} ({GetDurationInMinutes()} min): " + $"Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace {GetPace():0.0} min per km";
    }
}