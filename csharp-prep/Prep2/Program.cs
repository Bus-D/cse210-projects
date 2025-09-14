using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage grade? ");
        string valueFromUser = Console.ReadLine();
        int percent = int.Parse(valueFromUser);

        if (percent >= 60 && percent <= 69)
        {
            if (percent >= 60 && percent <= 63)
            {
                string grade = "D-";
                Console.Write($"Your grade is a {grade}. You shall not pass. Please try again.");
            }

            else if (percent >= 67 && percent <= 69)
            {
                string grade = "D+";
                Console.Write($"Your grade is a {grade}. You shall not pass. Please try again.");
            }
            else
            {
                string grade = "D";
                Console.Write($"Your grade is a {grade}. You shall not pass. Please try again.");
            }
        }

        else if (percent >= 70 && percent <= 79)
        {
            if (percent >= 70 && percent <= 73)
            {
                string grade = "C-";
                Console.Write($"Your grade is a {grade}. You barely passed! Keep trying to get better!");
            }

            else if (percent >= 77 && percent <= 79)
            {
                string grade = "C+";
                Console.Write($"Your grade is a {grade}. You barely passed! Keep trying to get better!");
            }
            else
            {
                string grade = "C";
                Console.Write($"Your grade is a {grade}. You barely passed! Keep trying to get better!");
            }
        }

        else if (percent >= 80 && percent <= 89)
        {
            if (percent >= 80 && percent <= 83)
            {
                string grade = "B-";
                Console.Write($"Your grade is a {grade}. You passed! A {grade} is pretty solid! Think you can do better?");
            }

            else if (percent >= 87 && percent <= 89)
            {
                string grade = "B+";
                Console.Write($"Your grade is a {grade}. You passed! A {grade} is pretty solid! Think you can do better?");
            }
            else
            {
                string grade = "B";
                Console.Write($"Your grade is a {grade}. You passed! A {grade} is pretty solid! Think you can do better?");
            }
        }

        else if (percent >= 90 && percent <= 100)
        {
            if (percent >= 90 && percent <= 93)
            {
                string grade = "A-";
                Console.Write($"Your grade is a {grade}. Wooooooo! An {grade}? Great job!");
            }

            else if (percent == 100)
            {
                string grade = "A+";
                Console.Write($"Holy cow! Your grade should be {grade}! But that technically doesn't exsit, so you get an A :(");
            }

            else
            {
                string grade = "A";
                Console.Write($"Your grade is a {grade}. Wooooooo! An {grade}? Great job!");
            }
        }


        else
        {
            string grade = "F";
            Console.Write($"Your grade is an {grade}. Congratulations, you have failed. Lucky for you, you can try aga||.");
        }
    }
}