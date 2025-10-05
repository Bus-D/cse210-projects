public class Assignment
{
    private string _studentName;
    private string _topic;


    public Assignment()
    {
        
    }

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetName
    {
        get { return _studentName; }
        set { _studentName = value; }
    }

    public string GetTopic
    {
        get { return _topic; }
        set { _topic = value; }
    }

    public string GetSummary()
    {
        Console.WriteLine($"{GetName} - {GetTopic}");
        return "";
    }
}