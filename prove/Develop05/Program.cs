using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    //www.plantuml.com/plantuml/png/lPBFJi904CRl-nIRS6bZUO760mQ9CI5AHCzaxGwmSTfjTeScH7rtEx2mfHWv8GVI_VRF_EQRR-H9ETgKA0fKtii7gr1-Yg5ShAp2rsqDkVJaJBKwQ4-gFDCUgwNjQpDhAlAvRFzPMXg4cQBryTX0BWfRrWW4kNot5eKOCqAIYdPlx40HC4soFn-1Cha8Ki3fAGoJSTakHohpNM_jqtFL07_wy79aIpjmZJLQtXjVezhkJwUjEhLANxxx0eLrUj90HP4-iAQXsO6yqthFblHPTwPnDMW0t-fVzfbEV8imjBbX7yFeuY8v-7jLHoF6XC1L2WF7JLp_Fyfu3SN7r7YAUGOUntDHR1peOoh9aa8Ur26fVs1V62jVlsfmksaygv-51dteC3lfBMLdTbRSVWs7dRn4CRRTLK-D5FmRGQKt9Vu0
    static void Main(string[] args)
    {
        Console.Clear();
        bool run = true;
        Goal goal = new Goal();

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
                    goal.StartCreation();
                    break;
                case 2:
                    goal.DisplayGoals();
                    break;
                case 3:
                    goal.SaveGoal();
                    break;
                case 4:
                    goal.LoadGoals();
                    break;
                case 5:
                    goal.RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("See you later!");
                    run = false;
                    break;
            }
        }
       
    }
}