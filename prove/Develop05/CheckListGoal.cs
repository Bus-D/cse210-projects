public class CheckListGoal : Goal
{
    public int goalAmount = 0;
    public int completedTimes = 0;
    public int extraPoints = 0;

    public CheckListGoal() { }

public CheckListGoal(string name, string info, int points, bool complete, int goalAmount, int completedTimes, int extraPoints) 
    : base(name, info, points)
{
    GoalName = name;
    GoalInfo = info;
    GoalPoints = points;
    _complete = complete;
    this.goalAmount = goalAmount;
    this.completedTimes = completedTimes;
    this.extraPoints = extraPoints;
}


    public override string CreateGoal()
    {
        GoalType = "CheckList Goal";

        Console.WriteLine("What is the name of your goal?");
        Console.Write("> ");
        this.GoalName = Console.ReadLine();

        Console.WriteLine("What is a short description of it?");
        Console.Write("> ");
        this.GoalInfo = Console.ReadLine();

        Console.WriteLine("How many points is it worth?");
        Console.Write("> ");
        this.GoalPoints = int.Parse(Console.ReadLine());

        Console.WriteLine("How many times do you want to complete the goal?");
        Console.Write("> ");
        this.goalAmount = int.Parse(Console.ReadLine());

        Console.WriteLine("How many extra points when you finish the goal?");
        Console.Write("> ");
        this.extraPoints = int.Parse(Console.ReadLine());

        string wholeGoal = $"{this.GoalType},{this.GoalName},{this.GoalInfo},{this.GoalPoints},{this._complete},{this.completedTimes},{this.goalAmount},{this.extraPoints}";
        return wholeGoal;
    }

    public override void DisplayGoals()
    {
        int counter = 1;
        if (_goals.Count == 0)
        {
            Console.WriteLine("No entries yet.\n");
            return;
        }

        foreach (Goal goal in _goals)
        {
            string checkbox = goal._complete ? "[X]" : "[ ]";

            Console.WriteLine($"{counter}. {checkbox} {goal.GoalName} ({goal.GoalInfo}) Points: {goal.GoalPoints} {completedTimes}/{goalAmount}");

            counter++;
        }

        Console.WriteLine($"Total Points: {TotalPoints}");
    }

    public override void RecordEvent()
    {
        DisplayGoals();

        Console.WriteLine("What goal would you like to record?");
        int goalChoice = int.Parse(Console.ReadLine());

        if (goalChoice >= 1 && goalChoice <= _goals.Count)
        {
            if (_goals[goalChoice - 1] is CheckListGoal selectedGoal)
            {
                if (selectedGoal.completedTimes < selectedGoal.goalAmount)
                {
                    selectedGoal.completedTimes++;
                    AddPoints(selectedGoal);
                }
                else
                {
                    selectedGoal._complete = true;
                    AddPoints(selectedGoal);
                }
            }
        }
    }

    protected void AddPoints(CheckListGoal goal)
    {
        TotalPoints += goal.GoalPoints;

        if (goal.completedTimes == goal.goalAmount)
        {
            TotalPoints += goal.extraPoints;
        }
    }
}
