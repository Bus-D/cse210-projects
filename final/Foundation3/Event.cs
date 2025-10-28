class Event
{
  private string _title;
  private string _type;
  private string _description;
  private string _date;
  private string _time;
  public Address _address;

  public string EventType
  {
    get { return _type; }
    set { _type = value; }
  }

  public string EventTitle
  {
    get { return _title; }
    set { _title = value; }
  }

  public string EventDescription
  {
    get { return _description; }
    set { _description = value; }
  }

  public string EventDate
  {
    get { return _date; }
    set { _date = value; }
  }

  public string EventTime
  {
    get { return _time; }
    set { _time = value; }
  }
  

  public Event(string title, string type, string description, string date, string time, Address address)
  {
    EventTitle = title;
    EventType = type;
    EventDescription = description;
    EventDate = date;
    EventTime = time;
    _address = address;
  }

  public string GetStandardDetails()
  {
    return $"{_type} Details:\n{_title}\nDate: {_date}, Time: {_time}, Address: {_address}\n{_description}\n";
  }

  public string GetFullDetails()
  {
    return "";
  }
  
  public string GetShortDescription()
  {
    return $"{_type} Details:\n{_title}\nDate: {_date}";
  }
}