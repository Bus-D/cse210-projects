using System.Reflection;

public class SimpleGoal : Goal
{
    public SimpleGoal() { }
    public SimpleGoal(string name, string info, int points, bool complete) : base(name, info, points)
    {
        GoalName = name;
        GoalInfo = info;
        GoalPoints = points;

    }
    public override string CreateGoal()
    {
        GoalType = "Simple Goal";
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


}