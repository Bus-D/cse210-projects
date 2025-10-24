using System.Reflection;

public class SimpleGoal : Goal
{
    public SimpleGoal() { }
    public SimpleGoal(string type, string name, string info, int points, bool complete) : base(name, info, points)
    {
        string _goalType = type;
        GoalName = name;
        GoalInfo = info;
        GoalPoints = points;

    }

    public override void RecordEvent(List<Goal> _goals)
    {
        DisplayGoals(_goals);

        Console.WriteLine("What goal would you like to record?");
        int goalChoice = int.Parse(Console.ReadLine());

        if (goalChoice >= 1 && goalChoice <= _goals.Count)
        {
            Goal selectedGoal = _goals[goalChoice - 1];
            selectedGoal._complete = true;
            AddPoints(selectedGoal, selectedGoal._complete);
            Console.WriteLine($"You earned {GoalPoints} points!");
        }
    }
    
    public override void AddPoints(Goal selectedGoal, bool complete)
    {
        if (selectedGoal != null && selectedGoal._complete)
        {
            _totalPoints += selectedGoal.GoalPoints;
        }
    }
}