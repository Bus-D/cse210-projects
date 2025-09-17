using System;
using System.Diagnostics.Contracts;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int totalGuessCount = 0;
        string keepPlaying = "yes";
        do
        {
            Random rng = new Random();
            int cpuNum = rng.Next(1, 101);
            int userNum = 0;
            int guessCount = 0;

            Console.WriteLine("Your task is to guess the magic number between 1-100");

            do
            {
                totalGuessCount++;
                guessCount++;
                Console.Write("What is your guess? ");
                string uNum = Console.ReadLine();
                userNum = int.Parse(uNum);

                if (userNum != cpuNum)
                {
                    if (userNum > cpuNum)
                    {
                        Console.WriteLine("Lower");
                    }
                    else if (userNum < cpuNum)
                    {
                        Console.WriteLine("Higher");
                    }
                }
                else
                {
                    guessCount = guessCount++;

                    if (guessCount == 1)
                    {
                        Console.WriteLine($"You guessed it in {guessCount} guess! That's incredible!");
                    }

                    else
                    {
                        Console.WriteLine($"You guessed it! It took you {guessCount} guesses");   
                    }
                }

            } while (userNum != cpuNum);

            Console.Write("Do you want to keep playing? yes/no: ");
            keepPlaying = Console.ReadLine();

        } while (keepPlaying == "yes");

        Console.Write($"Total guesses for all games: {totalGuessCount}");
        
        

    }
}