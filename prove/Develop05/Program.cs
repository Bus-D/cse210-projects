using System;
// move create method into here. use it to construct each class via calling the specific class
class Program
{
    //www.plantuml.com/plantuml/png/lPBFJi904CRl-nIRS6bZUO760mQ9CI5AHCzaxGwmSTfjTeScH7rtEx2mfHWv8GVI_VRF_EQRR-H9ETgKA0fKtii7gr1-Yg5ShAp2rsqDkVJaJBKwQ4-gFDCUgwNjQpDhAlAvRFzPMXg4cQBryTX0BWfRrWW4kNot5eKOCqAIYdPlx40HC4soFn-1Cha8Ki3fAGoJSTakHohpNM_jqtFL07_wy79aIpjmZJLQtXjVezhkJwUjEhLANxxx0eLrUj90HP4-iAQXsO6yqthFblHPTwPnDMW0t-fVzfbEV8imjBbX7yFeuY8v-7jLHoF6XC1L2WF7JLp_Fyfu3SN7r7YAUGOUntDHR1peOoh9aa8Ur26fVs1V62jVlsfmksaygv-51dteC3lfBMLdTbRSVWs7dRn4CRRTLK-D5FmRGQKt9Vu0
    static void Main(string[] args)
    {
        List<Goal> _goals = new List<Goal>();
        Console.Clear();
        bool run = true;
        Goal goal = new Goal();
        string goalType = "";

        Console.WriteLine("Welcome to the Eternal Goal Program!");

        

        while (run)
        {
            Console.WriteLine("Menu Options:\n" +
            "1. Create New Goal\n" +
            "2. List Goals\n" +
            "3. Save Goals\n" +
            "4. Load Goals\n" +
            "5. Record Event\n" +
            "6. Quit"
            );
            Console.Write("\n> ");

            int choice = int.Parse(Console.ReadLine());

             switch (choice)
            {
                case 1:
                    Console.WriteLine("Which type of Goal would you like to create?");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("> ");
                    int goalChoice = int.Parse(Console.ReadLine());

                    switch (goalChoice)
                    {
                        case 1:
                            goalType = "Simple Goal";
                            Console.Write("What is the name of your goal? ");
                            string goalName = Console.ReadLine();
                            Console.Write("What is a short description of your goal? ");
                            string goalInfo = Console.ReadLine();
                            Console.Write("How many points is it worth? ");
                            int goalPoints = int.Parse(Console.ReadLine());

                            SimpleGoal simple = new SimpleGoal(goalType, goalName, goalInfo, goalPoints, false);
                            _goals.Add(simple);
                            break;

                        case 2:
                            goalType = "Eternal Goal";
                            Console.Write("What is the name of your goal? ");
                            goalName = Console.ReadLine();
                            Console.Write("What is a short description of your goal? ");
                            goalInfo = Console.ReadLine();
                            Console.Write("How many points is it worth? ");
                            goalPoints = int.Parse(Console.ReadLine());

                            EternalGoal eternal = new EternalGoal(goalType, goalName, goalInfo, goalPoints);
                            _goals.Add(eternal);
                            break;
                        case 3:
                            goalType = "Checklist Goal";
                            Console.Write("What is the name of your goal? ");
                            goalName = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            goalInfo = Console.ReadLine();
                            int completedTimes = 0;
                            Console.Write("How many times do you want to do the goal? ");
                            int goalAmount = int.Parse(Console.ReadLine());
                            Console.Write("How many points is it worth when working to complete the goal? ");
                            goalPoints = int.Parse(Console.ReadLine());
                            Console.Write("How many points is it worth when you complete the goal? ");
                            int completePoints = int.Parse(Console.ReadLine());
                            
                            CheckListGoal checklist = new CheckListGoal(goalType, goalName, goalInfo, goalPoints, false, goalAmount, completedTimes, completePoints);
                            _goals.Add(checklist);
                            break;
                    }       
                    break;
                case 2:
                    Console.WriteLine("Your Goals:");
                    foreach (Goal g in _goals)
                    {
                        if (goalType == "Checklist Goal")
                        {
                            g.DisplayGoals(_goals);
                        }
                        else
                        {
                            g.DisplayGoals(_goals);
                        }
                    }
                    
                    break;
                case 3:
                    goal.SaveGoal(_goals);
                    break;
                case 4:
                    goal.LoadGoals(_goals);
                    break;
                case 5:
                    if (goalType == "Checklist Goal")
                    {
                        foreach (CheckListGoal g in _goals)
                        {
                            g.RecordEvent(_goals);
                        }
                    }
                    else
                    {
                        foreach (Goal g in _goals)
                        {
                            g.RecordEvent(_goals);
                        }
                    }
                    break;
                case 6:
                    Console.WriteLine("See you later!");
                    run = false;
                    break;
            }
        }
       
    }
}