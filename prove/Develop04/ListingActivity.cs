public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    string userInput;

    private List<string> _inputs = new List<string> { };

    public ListingActivity(string StartMessage, string EndMessage, int RunTime) : base(StartMessage, EndMessage, RunTime)
    {
        StartMessage = "Welcome to the Listing Activity!\n" +
        "In this activity you will be given a prompt for you to write your thoughts down. After a specified amount of time the program will end.\n" +
        "Please enter the amount of time you wish to run the activity in seconds\n";
        Console.Write("> ");

        RunTime = int.Parse(Console.ReadLine());

        EndMessage = $"Session Complete! You wrote {_inputs.Count} number of thought(s).";
    }

    public void DisplayEntries()
    {
        foreach (string input in _inputs)
        {
            Console.WriteLine(_inputs);
        }
    }

    public void KeepPrompting()
    {
        DateTime startTime = DateTime.Now;

        Random random = new Random();
        int randomNumber = random.Next(0, _inputs.Count);
        Console.WriteLine(base.StartMessage);
        base.RunTime = int.Parse(Console.ReadLine());

        Console.WriteLine("Type 'exit' to quit before the timer is up");
        Console.Write(_prompts[randomNumber]);
        Console.Write("> ");

        while ((DateTime.Now - startTime).TotalSeconds < RunTime)
        {
            int currentLineCursorTop = Console.CursorTop;
            int currentLineCursorLeft = Console.CursorLeft;

            userInput = Console.ReadLine();

            if (userInput.ToLower() == "exit")
            {
                break;
            }

            _inputs.Add(userInput);

            Console.SetCursorPosition(0, currentLineCursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursorTop);
        }

        Console.WriteLine(base.EndMessage);
    }

}