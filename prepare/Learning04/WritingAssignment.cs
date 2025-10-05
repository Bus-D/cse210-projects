public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment()
    {

    }

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetTitle
    {
        get { return _title; }
        set { _title = value; }
    }

    public void GetWritingInfo()
    {
        Console.WriteLine($"{GetName} - {GetTopic}\n{GetTitle}");
    }
}