public class BreathingActivity : Activity
{
    public BreathingActivity(string StartMessage, string EndMessage, int RunTime) : base(StartMessage, EndMessage, RunTime)
    {
        StartMessage = "\nWelcome to the Breathing Activity!" +
        "\nThis activity will lead you through a session of breathing activities." +
        "\nTo begin, enter the amount of time you wish to do the activity in seconds.\n";

        Console.Write("> ");

        RunTime = int.Parse(Console.ReadLine());

        EndMessage = "Session Complete! Thank you for participating in the breathing activity!";
    }

    public void RunBreathing()
    {
        DateTime startTime = DateTime.Now;

        Console.Write(base.StartMessage);
        base.RunTime = int.Parse(Console.ReadLine());

        Console.WriteLine($"Starting a {base.RunTime} second mindfulness session.");
        Console.WriteLine("Focus on your breathing... \n");

        while ((DateTime.Now - startTime).TotalSeconds < RunTime)
        {
            Console.WriteLine("Take a deep breath and hold...");
            base.PauseAnimation(10); // Hard coded for 10 seconds for testing

            Console.WriteLine("Relax and breathe normally.\n");
            Thread.Sleep(3000);
        }

        Console.WriteLine(base.EndMessage);
    }
}