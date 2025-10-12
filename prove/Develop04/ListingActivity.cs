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

    public ListingActivity(string StartMessage, string EndMessage, int RunTime) : base(StartMessage, EndMessage, RunTime)
    {
        StartMessage = "Welcome to the Listing Activity!\n" +
        "In this activity you will be given a prompt for you to write your thoughts down. After a specified amount of time the program will end.\n" +
        "Please enter the amount of time you wish to run the activity in seconds\n";
        Console.Write("> ");

        EndMessage = $"Session Complete! Thank you for participating";
    }

    public void RunListing()
    {
        Console.WriteLine(base.StartMessage);
        Console.Write("> ");
        RunTime = int.Parse(Console.ReadLine());
        Console.Clear();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("You'll have a few seconds to think before you start");
        PauseAnimation(3);

        DateTime startTime = DateTime.Now;
        List<string> responses = new List<string>();

        Console.WriteLine("Start listing items (press Enter after each): ");

        while ((DateTime.Now - startTime).TotalSeconds < RunTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
            {
                responses.Add(input);
            }
        }

        Console.WriteLine($"\nYou listed {responses.Count} item(s)!");
        Console.WriteLine(EndMessage);
    }

}