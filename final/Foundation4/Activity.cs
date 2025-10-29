abstract class Activity
{
  protected string _date;
  protected int _lengthMinutes;
  protected string _type;

  public Activity(string date, int minutes, string type)
  {
    _date = date;
    _lengthMinutes = minutes;
    _type = type;
  }

  protected abstract double GetDistance();

  protected abstract double GetPace();

  protected abstract double GetSpeed();

  public abstract string GetSummary();

}