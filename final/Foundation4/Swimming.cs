class Swimming : Activity
{
  private int _laps;

  public Swimming(string date, int minutes, string type, int laps) : base(date, minutes, type)
  {
    _laps = laps;
  }

  protected override double GetDistance()
  {
    return _laps * 50 / 1000 * 0.62;
  }
  protected override double GetPace()
  {
    return Minutes / GetDistance();
  }
  protected override double GetSpeed()
  {
    return (GetDistance() / Minutes) * 60;
  }
  public override string GetSummary()
  {
    return $"{Date} {Type} ({Minutes}) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min/mile";
  }
}