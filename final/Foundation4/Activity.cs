class Activity
{
  private string _date;
  private int _lengthMinutes;
  private string _type;

  public string Date
  {
    get { return _date; }
    set { _date = value; }
  }

  public int Minutes
  {
    get { return _lengthMinutes; }
    set { _lengthMinutes = value; }
  }

  public string Type
  {
    get { return _type; }
    set { _type = value; }
  }

  public Activity(string date, int minutes, string type)
  {
    _date = date;
    _lengthMinutes = minutes;
    _type = type;
  }

  protected virtual double GetDistance()
  {
    return 0.0;
  }
  protected virtual double GetPace()
  {
    return 0.0;
  }
  protected virtual double GetSpeed()
  {
    return 0.0;
  }
  public virtual string GetSummary()
  {
    return "";
  }
}