public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetTextBook
    {
        get { return _textbookSection; }
        set { _textbookSection = value; }
    }
    public string GetProblems
    {
        get { return _problems; }
        set { _problems = value; }
    }

    public void GetHomeWorkList()
    {
        Console.WriteLine($"{GetName} - {GetTopic } \nSection: {GetTextBook} Problems: {GetProblems}");
    }
}