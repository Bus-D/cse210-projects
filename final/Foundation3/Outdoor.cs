class Outdoor : Event
{
  private string _weatherForecast;

  public Outdoor(string title, string type, string description, string date, string time, Address address, string weather) : base(title, type, description, date, time, address)
  {
    _weatherForecast = weather;
  }

  protected string GetFullString()
  {
    return $"{EventType} Details:\n{EventTitle}\nDate: {EventDate}, Time: {EventTime}, Address: {_address}\n{EventDescription}\nForecasted Weather: {_weatherForecast}";
  }
}