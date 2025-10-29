class Cycling : Activity
{
  private double _speed;

  public Cycling(string date, int minutes, string type, double speed, double distance) : base(date, minutes, type)
  {
    _speed = speed;
  }

    protected override double GetDistance()
  {
    return _speed * (_lengthMinutes/60);
  }
  protected override double GetPace()
  {
    return _lengthMinutes / this.GetDistance();
  }

  protected override double GetSpeed()
  {
    return (this.GetDistance() / _lengthMinutes) * 60;
  }

  public override string GetSummary()
  {
    return $"{_date} {_type} ({_lengthMinutes}) - Distance {GetDistance()} km, Speed {GetSpeed()} kmph, Pace: {GetPace()} min/km";
  }
}