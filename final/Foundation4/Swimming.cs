class Swimming : Activity
{
  private int _laps;

  public Swimming(string date, int minutes, string type, int laps) : base(date, minutes, type)
  {
    _laps = laps; 
  }

  protected override double GetDistance()
  {
    return  _laps * 50 / 1000;
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