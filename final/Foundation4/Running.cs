using System.Reflection.Metadata.Ecma335;

class Running : Activity
{
  private double _distance;

  public Running(string date, int minutes, double distance, string type) : base(date, minutes, type)
  {
    _distance = distance;
  }

  protected override double GetDistance()
  {
    return _distance;
  }
  protected override double GetPace()
  {
    return Minutes / _distance;
  }

  protected override double GetSpeed()
  {
    return (_distance * Minutes) * 60;
  }

  public override string GetSummary()
  {
    return $"{Date} {Type} ({Minutes}) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min/mile";
  }
}