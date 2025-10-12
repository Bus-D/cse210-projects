public class BreathingActivity : Activity
{
    public BreathingActivity(string StartMessage, string EndMessage, int RunTime) : base(StartMessage, EndMessage, RunTime)
    {
        StartMessage = "\nWelcome to the Breathing Activity!" +
        "\nThis activity will lead you through a session of breathing activities." +
        "\nTo begin, enter the amount of time you wish to do the activity in seconds.\n";

        EndMessage = "Session Complete! Thank you for participating in the breathing activity!";
    }

    public void RunBreathing()
    {
        Console.WriteLine(StartMessage);
        
        Console.Write("> ");
        RunTime = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine($"Starting a {base.RunTime} second breathing session.");
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < RunTime)
        {
            Console.WriteLine("Breathe in...");
            PauseAnimation(4);
            Console.WriteLine("Now breathe out...");
            PauseAnimation(4);
            Console.WriteLine();
        }

        Console.WriteLine(EndMessage);
    }
}