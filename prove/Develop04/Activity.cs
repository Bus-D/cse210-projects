using System.Data;
using System.Xml.Serialization;

public class Activity
{
    private string _startMessage;
    private string _endMessage;
    private int _runTime;
    private int _pauseSeconds;
    private int _input;


    public string StartMessage
    {
        get { return _startMessage; }
        set { _startMessage = value; }
    }
    public string EndMessage
    {
        get { return _endMessage; }
        set { _endMessage = value; }
    }
    public int RunTime
    {
        get { return _runTime; }
        set { _runTime = value; }
    }
    public int PauseSeconds
    {
        get { return _pauseSeconds; }
        set { _pauseSeconds = value; }
    }

    public int Input
    {
        get { return _input; }
        set { _input = value; }
    }

    public Activity()
    {

    }

    public Activity(string startMessage, string endMessage)
    {
        StartMessage = startMessage;
        EndMessage = endMessage;
    }

    public Activity(int runTime, int pauseSeconds)
    {
        RunTime = runTime;
        PauseSeconds = pauseSeconds;
    }
    public Activity(string startMessage, string endMessage, int runTime)
    {
        StartMessage = startMessage;
        EndMessage = endMessage;
        RunTime = runTime;
    }

    protected void DisplayRandom()
    {
        Random _random = new Random();
    }

    public int DisplayStart()
    {
        Console.WriteLine("Welcome to the Mindfullness Program!");
        Console.WriteLine("Please select an activity. The instructions for each task will follow.");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("> ");

        Input = int.Parse(Console.ReadLine());
        return Input;
    }

    public void DisplayEnd()
    {
        Console.WriteLine(EndMessage);
    }

    public void PauseAnimation(int time)
    {
        PauseSeconds = time;
        for (int i = time; i > 0; i--)
        {
            Console.Write($"\rCountdown: {i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine("\rTime's up! ");
    }

    public void RunActivity()
    {
  
    }
}