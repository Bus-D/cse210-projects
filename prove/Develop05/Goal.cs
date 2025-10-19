using System.Diagnostics.Metrics;

public class Goal
{
    protected static List<Goal> _goals = new List<Goal>();
    private string _goalType;
    private string _goalName;
    private string _goalInfo;
    private int _goalPoints;
    private static int _totalPoints;
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

    public virtual string CreateGoal()
    {
        bool typeChosen = false;
        
        Console.WriteLine("Which type of Goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("> ");
        int choice = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        while (!typeChosen)
        {
            if (choice == 1)
            {
                newGoal = new SimpleGoal();
                _goalType = "Simple Goal";
                typeChosen = true;
            }
            else if (choice == 2)
            {
                newGoal = new EternalGoal();
                _goalType = "Eternal Goal";
                typeChosen = true;
            }
            else if (choice == 3)
            {
                newGoal = new CheckListGoal();
                _goalType = "ChecklistGoal";
                typeChosen = true;
            }
            else
            {
                Console.WriteLine("Invalid Choice. Please Choose the type of goal");
            }

            if (newGoal != null)
            {
                if (newGoal is CheckListGoal checkGoal)
                {
                    checkGoal.CreateGoal(); // sets properties on the object
                }
                else
                {
                    newGoal.CreateGoal(); // Simple or Eternal goals
                }

                _goals.Add(newGoal);
            }
        }
        return "";
    }

    public void StartCreation()
    {
        CreateGoal();
    }

    public void SaveGoal()
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

public void LoadGoals()
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
                    goal = new SimpleGoal(name, info, points, complete);
                    break;
                case "Eternal Goal":
                    goal = new EternalGoal(name, info, points);
                    goal._complete = complete;
                    break;
                case "ChecklistGoal":
                    goal = new CheckListGoal(name, info, points, complete, goalAmount, completedTimes, extraPoints);
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



    public virtual void DisplayGoals()
    {
        int counter = 1;
        if (_goals.Count == 0)
        {
            Console.WriteLine("No entries yet.\n");
            return;
        }
        else
        {
            Console.WriteLine($"Total Points: {_totalPoints}");

            foreach (Goal goal in _goals)
            {
                string checkbox = goal._complete ? "[X]" : "[ ]";
                Console.WriteLine($"{counter}. {checkbox} {goal.GoalName} ({goal.GoalInfo}) Points: {goal.GoalPoints}");
                counter++;
            }

        }
    }

    public virtual void RecordEvent()
    {
        DisplayGoals();

        Console.WriteLine("What goal would you like to record?");
        int goalChoice = int.Parse(Console.ReadLine());

        if (goalChoice >= 1 && goalChoice <= _goals.Count)
        {
            Goal selectedGoal = _goals[goalChoice - 1];
            selectedGoal._complete = true;
            AddPoints(selectedGoal);
        }

        DisplayGoals();
    }

    protected virtual void AddPoints(Goal selectedGoal)
    {
        if (selectedGoal != null && selectedGoal._complete)
        {
            _totalPoints += selectedGoal.GoalPoints;
        }
    }
}