using System.Net;

class Video
{
    public List<Comment> _comments = new List<Comment>();
    private string _title;
    private string _length;
    private string _author;
    private int _numberComments;

    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public int CommentNumber(int number)
    {
        int commentNumber = number;
        number = _comments.Count();
        return number;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title} by {_author}");
        Console.WriteLine($"{_length}");
        Console.WriteLine($"{CommentNumber(_numberComments)} comments: ");

        foreach (Comment c in _comments)
        {
            c.MakeComment();
        }
        Console.WriteLine();
    }
}