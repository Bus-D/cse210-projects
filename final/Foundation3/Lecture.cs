using System.ComponentModel;

class Lecture : Event
{
  private string _speaker;
  private int _capacity;

  public Lecture(string title, string type, string description, string date, string time, Address address, string speaker, int capacity) : base(title, type, description, date, time, address)
  {
    _speaker = speaker;
    _capacity = capacity;
  }

  public new string GetFullDetails()
  {
    return $"{EventType} Details:\n{EventTitle}\nDate: {EventDate}, Time: {EventTime}, Address: {_address}\nSpeaker: {_speaker}\nCapacity: {_capacity}\n{EventDescription}";
  }
}