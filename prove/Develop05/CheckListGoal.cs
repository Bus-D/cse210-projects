using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;

public class CheckListGoal : Goal
{
    public int goalAmount = 0;
    public int completedTimes = 0;
    public int extraPoints = 0;

    public CheckListGoal() { }

public CheckListGoal(string type, string name, string info, int points, bool complete, int goalAmount, int completedTimes, int extraPoints) 
    : base(name, info, points)
{
    string _goalType = type;
    GoalName = name;
    GoalInfo = info;
    GoalPoints = points;
    _complete = complete;
    this.goalAmount = goalAmount;
    this.completedTimes = completedTimes;
    this.extraPoints = extraPoints;
}

    public override string GetDisplayString()
    {
        string checkbox = _complete ? "[X]" : "[ ]";
        return $"{checkbox} {GoalName} ({GoalInfo}) Points: {GoalPoints} Progress: {completedTimes}/{goalAmount}";
    }

    public override void DisplayGoals(List<Goal> _goals)
    {
        int counter = 1;
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to display.\n");
            return;
        }

        Console.WriteLine($"Total Points: {_totalPoints}");  
        foreach (Goal g in _goals)
        {
            Console.WriteLine($"{counter}. {g.GetDisplayString()}");
            counter++;
        }
    }

    public override void RecordEvent(List<Goal> _goals)
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
            return;
        }
        else
        {
            Console.WriteLine("Select a goal to record progress: \n");
            for (int i = 0; i < _goals.Count; i++)
            {
                Goal g = _goals[i];
                string checkbox = g._complete ? "[X]" : "[ ]";
                Console.WriteLine($"{i + 1}. {checkbox} {g.GoalName} ({g.GoalInfo}) {GoalPoints} Progress: {completedTimes}/{goalAmount}");
            }

            int choice = int.Parse(Console.ReadLine());

            if (choice >= 1 && choice <= _goals.Count)
            {
                _goals[choice - 1].RecordEvent(_goals);
            }

            if (completedTimes >= goalAmount)
            {
                _complete = true;
                TotalPoints += extraPoints;
                Console.WriteLine($"You earned {extraPoints} points!");
            }
            else
            {
                completedTimes++;
                TotalPoints += GoalPoints;
                Console.WriteLine($"You earned {GoalPoints} points!");
            }
        }
    }

    public override void AddPoints(Goal goal, bool isComplete)
    {
        TotalPoints += goal.GoalPoints;

        if (isComplete && completedTimes == goalAmount)
        {
            TotalPoints += extraPoints;
        }
    }
}
