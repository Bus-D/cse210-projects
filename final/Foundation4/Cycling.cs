class Cycling : Activity
{
  private double _speed;

  public Cycling(string date, int minutes, string type, double speed) : base(date, minutes, type)
  {
    _speed = speed;
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