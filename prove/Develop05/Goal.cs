using System.Diagnostics.Metrics;

public class Goal
{
    
    private string _goalType;
    private string _goalName;
    private string _goalInfo;
    private int _goalPoints;
    public int _totalPoints;
    private string _filePath;
    public bool _complete;

    public string GoalType
    {
        get { return _goalType; }
        set { _goalType = value; }
    }
    public string GoalName
    {
        get { return _goalName; }
        set { _goalName = value; }
    }
    public string GoalInfo
    {
        get { return _goalInfo; }
        set { _goalInfo = value; }
    }
    public int GoalPoints
    {
        get { return _goalPoints; }
        set { _goalPoints = value; }
    }
    public int TotalPoints
    {
        get { return _totalPoints; }
        set { _totalPoints = value; }
    }
    public string FilePath
    {
        get { return _filePath; }
        set { _filePath = value; }
    }
    public Goal() { }

    protected Goal(string name, string info, int points)
    {
        _goalName = name;
        _goalInfo = info;
        _goalPoints = points;
    }

    public void SaveGoal(List<Goal> _goals)
    {
        char[] delimiters = { '.' };
        string[] excludedExtensions = { ".cs", ".csproj" };


        string folderPath = @"C:\Users\brand\OneDrive - BYU-Idaho\School Work\Fall 2025\cse 210\cse210-projects\prove\Develop05";

        try
        {

            if (!Directory.Exists(folderPath))
            {
                Console.WriteLine($"Error: Folder at '{folderPath}'");
                return;
            }
            else
            {
                string[] files = Directory.GetFiles(folderPath);
                int counter = 1;
                List<string> validFiles = new List<string>();

                if (validFiles.Count == 0)
                {
                    Console.WriteLine("What do you want to name the file?");
                    string fileName = Console.ReadLine();
                    _filePath = $"{fileName}.csv";

                    try
                    {
                        using (StreamWriter output = new StreamWriter(_filePath, false))
                        {
                            // CSV header
                             output.WriteLine("Type,Name,Info,Points,Complete,CompletedTimes,GoalAmount,ExtraPoints,TotalPoints");

                            foreach (Goal goal in _goals)
                            {
                                output.WriteLine($"{goal.GoalType},{goal.GoalName},{goal.GoalInfo},{goal.GoalPoints},{goal._complete},0,0,0,{TotalPoints}");
                            }

                            
                        }

                        Console.WriteLine($"Saved to {_filePath}\n");
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }
                else
                {
                    foreach (string filePath in files)
                    {
                        string extension = Path.GetExtension(filePath).ToLower();

                        if (!excludedExtensions.Contains(extension))
                        {
                            Console.WriteLine($"{counter}. {Path.GetFileName(filePath)}");
                            validFiles.Add(filePath);
                            counter++;
                        }
                    }

                    Console.WriteLine("Which file would you like to save to?");
                    int fileChoice = int.Parse(Console.ReadLine());

                    if (fileChoice >= 1 && fileChoice <= validFiles.Count)
                    {
                        _filePath = validFiles[fileChoice - 1];
                    }

                    try
                    {
                        using (StreamWriter output = new StreamWriter(_filePath, false))
                            {
                                output.WriteLine("Type,Name,Info,Points,Complete,CompletedTimes,GoalAmount,ExtraPoints,TotalPoints");

                                foreach (Goal goal in _goals)
                                {
                                    string line;
                                    if (goal is CheckListGoal c)
                                    {
                                        line = $"{c.GoalType},{c.GoalName},{c.GoalInfo},{c.GoalPoints},{c._complete},{c.completedTimes},{c.goalAmount},{c.extraPoints},{TotalPoints}";
                                    }
                                    else
                                    {
                                        line = $"{goal.GoalType},{goal.GoalName},{goal.GoalInfo},{goal.GoalPoints},{goal._complete},0,0,0,{TotalPoints}";
                                    }
                                    output.WriteLine(line);
                                }
                            }


                        Console.WriteLine($"Saved to {_filePath}\n");
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }
                }  
            }

        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine($"Error: Access to '{folderPath}' is denied. Check Permissions");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

public void LoadGoals(List<Goal> _goals)
{
    string folderPath = @"C:\Users\brand\OneDrive - BYU-Idaho\School Work\Fall 2025\cse 210\cse210-projects\prove\Develop05";
    string[] excludedExtensions = { ".cs", ".csproj" };

    if (!Directory.Exists(folderPath))
    {
        Console.WriteLine($"Error: Folder at '{folderPath}' does not exist.");
        return;
    }

    try
    {
        string[] allFiles = Directory.GetFiles(folderPath);
        List<string> validFiles = new List<string>();
        int counter = 1;

        // Show valid files
        foreach (string file in allFiles)
        {
            string extension = Path.GetExtension(file).ToLower();
            if (!excludedExtensions.Contains(extension))
            {
                Console.WriteLine($"{counter}. {Path.GetFileName(file)}");
                validFiles.Add(file);
                counter++;
            }
        }

        if (validFiles.Count == 0)
        {
            Console.WriteLine("No valid files found to load.");
            return;
        }

        Console.WriteLine("Which file would you like to load? (Enter number)");
        int input = int.Parse(Console.ReadLine());

        if (input < 1 || input > validFiles.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        string selectedFile = validFiles[input - 1];

        string[] lines = File.ReadAllLines(selectedFile);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++) // skip header
        {
            string[] parts = lines[i].Split(',');
            if (parts.Length < 9) continue;

            string goalType = parts[0];
            string name = parts[1];
            string info = parts[2];
            int points = int.Parse(parts[3]);
            bool complete = bool.Parse(parts[4]);
            int completedTimes = int.Parse(parts[5]);
            int goalAmount = int.Parse(parts[6]);
            int extraPoints = int.Parse(parts[7]);
            int totalPoints = int.Parse(parts[8]);

            Goal goal = null;

            switch (goalType)
            {
                case "Simple Goal":
                    goal = new SimpleGoal(goalType, name, info, points, complete);
                    break;
                case "Eternal Goal":
                    goal = new EternalGoal(goalType, name, info, points);
                    goal._complete = complete;
                    break;
                case "Checklist Goal":
                    goal = new CheckListGoal(goalType, name, info, points, complete, goalAmount, completedTimes, extraPoints);
                    break;
            }

            if (goal != null)
            {
                _goals.Add(goal);
                TotalPoints = totalPoints;
            }
        }

        Console.WriteLine($"Goals loaded successfully from {Path.GetFileName(selectedFile)}!");
    }
    catch (UnauthorizedAccessException)
    {
        Console.WriteLine($"Error: Access to '{folderPath}' is denied. Check permissions.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An unexpected error occurred: {ex.Message}");
    }
}


    public virtual string GetDisplayString()
    {
        string checkbox = _complete ? "[X]" : "[ ]";
        return $"{checkbox} {GoalName} ({GoalInfo}) Points: {GoalPoints}";
    }
    public virtual void DisplayGoals(List<Goal> _goals)
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

    public virtual void RecordEvent(List<Goal> _goals)
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
                Console.WriteLine($"{i + 1}. {checkbox} {g.GoalName} ({g.GoalInfo})");
            }

            int choice = int.Parse(Console.ReadLine());

            if (choice >= 1 && choice <= _goals.Count)
            {
                _goals[choice - 1].RecordEvent(_goals);
            }
        }
    }

    public virtual void AddPoints(Goal selectedGoal, bool complete)
    {
        if (selectedGoal != null && selectedGoal._complete)
        {
            _totalPoints += selectedGoal.GoalPoints;
        }
    }
}