class Reception : Event
{
  private string _rsvpEmail;

  public Reception(string title, string type, string description, string date, string time, Address address, string email) : base(title, type, description, date, time, address)
  {
    _rsvpEmail = email;
  }

  protected new string GetFullDetails()
  {
    return $"{EventType} Details:\n{EventTitle}\nDate: {EventDate}, Time: {EventTime}, Address: {_address}\n{EventDescription}\nRSVP: {_rsvpEmail}";
  }
}