using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Entry
{

    Random random = new Random();

    public string _entry;
    public string _time;
    public string _location;
    public int _randomNumber;

    // Prompts
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my day?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something new I learned today?",
        "Who did I help or serve today?",
        "What is one thing I am grateful for today?",
        "What challenged me the most today?",
        "Where did I feel the most peace today?",
        "What is one thing I want to remember about today?",
        "How did I show love or kindness today?",
        "What is one way I grew stronger or better today?",
        "What was the biggest surprise of my day?",
        "What is one prayer I want to offer about today?"
    };

    // Generates a random number for prompt
    public void GivePrompt()
    {
        _randomNumber = random.Next(_prompts.Count);
    }

    public string EntryCollection()
    {
        GivePrompt();
        GetTime();

        string prompt = _prompts[_randomNumber];
        Console.WriteLine(prompt);

        Console.Write("> ");
        string input = Console.ReadLine();
        Console.WriteLine("");

        AddLocation();

        _entry = $"Date: {_time} | Location: {_location} | Prompt: {prompt}\n {input}";
        return _entry;
    }

    // Get Time
    public void GetTime() {
        DateTime _currentTime = DateTime.Now;
        _time = _currentTime.ToShortDateString();
    }
  
    //Add Location

    public void AddLocation()
    {

        Console.WriteLine("Where are you writing at today? ");
        Console.Write("> ");
        _location = Console.ReadLine();
    }

}