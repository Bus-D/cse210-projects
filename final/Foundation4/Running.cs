using System.Reflection.Metadata.Ecma335;

class Running : Activity
{
  private double _distance;

  public Running(string date, double minutes, double distance, string type) : base(date, minutes, type)
  {
    _distance = distance;
  }

  protected override double GetDistance()
  {
    return _distance;
  }
  protected override double GetPace()
  {
    return _lengthMinutes / _distance;
  }

  protected override double GetSpeed()
  {
    return (_distance / _lengthMinutes) * 60;
  }

  public override string GetSummary()
  {
    return $"{_date} {_type} ({_lengthMinutes}) - Distance {GetDistance()} km, Speed {GetSpeed()} kmph, Pace: {GetPace()} min/km";
  }
}