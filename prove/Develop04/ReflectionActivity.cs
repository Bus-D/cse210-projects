public class ReflectionActivity : Activity
{

    private int currentAnimationFrame;
    private char[] spinnerAnimationFrames = { '|', '/', '-', '\\' };
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _reflectionQuestion = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string startMessage, string endMessage, int runTime) : base(startMessage, endMessage, runTime)
    {
        startMessage = "Welcome to the Reflection Activity!\n" +
        "In this activity you will be given the opportunity to enter an amount of time you want to relfect.\n" +
        "You will then be given a prompt followed by questions to help you reflect on the prompt.\n" +
        "Please enter the amount of time you wish to run the activity.\n";

        endMessage = "Thank you for reflecting today.";
    }

    public void SpinnerAnimation(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            foreach (char c in spinnerAnimationFrames)
            {
                Console.Write($"\r{c}");
                Thread.Sleep(200);
            }
        }
        Console.Write("\r");
    }
    
    public void RunReflection()
    {
        DateTime startTime = DateTime.Now;

        Console.WriteLine(base.StartMessage);
        Console.Write("> ");
        RunTime = int.Parse(Console.ReadLine());
        Console.Clear();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"Prompt: \n> {prompt}\n");
        Console.WriteLine("Reflecting on this... get ready...");
        SpinnerAnimation(3);

        while ((DateTime.Now - startTime).TotalSeconds < RunTime)
        {
            string quesiton = _reflectionQuestion[random.Next(_reflectionQuestion.Count)];
            Console.WriteLine($"\n{quesiton}");
            SpinnerAnimation(5);
        }

        Console.WriteLine("\n" + EndMessage);
    }
}