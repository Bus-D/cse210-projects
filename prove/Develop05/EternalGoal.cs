public class EternalGoal : Goal
{
    public EternalGoal() { }
    public EternalGoal(string name, string info, int points) :base(name, info, points)
    {
        GoalName = name;
        GoalInfo = info;
        GoalPoints = points;
    }
    public override string CreateGoal()
    {
        GoalType = "Eternal Goal";
        Console.WriteLine("What is the name of your goal?");
        Console.Write("> ");
        this.GoalName = Console.ReadLine();

        Console.WriteLine("What is a short description of it?");
        Console.Write("> ");
        this.GoalInfo = Console.ReadLine();

        Console.WriteLine("How many points is it worth?");
        Console.Write("> ");
        this.GoalPoints = int.Parse(Console.ReadLine());

        string wholeGoal = $"{this.GoalType},{this.GoalType},{this.GoalName},{this.GoalInfo},{this.GoalPoints}";
        return wholeGoal;
    }
    
    public override void RecordEvent()
    {
        DisplayGoals();
        Console.WriteLine("What goal would you like to record?");
        int goalChoice = int.Parse(Console.ReadLine());

        if (goalChoice >= 1 && goalChoice <= _goals.Count)
        {
            Goal selectedGoal = _goals[goalChoice - 1];
            TotalPoints += selectedGoal.GoalPoints;
        }

        DisplayGoals();
    }
}