public class EternalGoal : Goal
{
    public EternalGoal() { }
    public EternalGoal(string type, string name, string info, int points) : base(name, info, points)
    {
        string _goalType = type;
        GoalName = name;
        GoalInfo = info;
        GoalPoints = points;
        _complete = false;
    }
    public override void RecordEvent(List<Goal> _goals)
    {
        DisplayGoals(_goals);
        Console.WriteLine("What goal would you like to record?");
        int goalChoice = int.Parse(Console.ReadLine());

        if (goalChoice >= 1 && goalChoice <= _goals.Count)
        {
            Goal selectedGoal = _goals[goalChoice - 1];
            TotalPoints += selectedGoal.GoalPoints;
            _complete = false; 
            selectedGoal.AddPoints(selectedGoal, false);
        }

        DisplayGoals(_goals);
    }
}