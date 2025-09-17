using System;

class Program
{
    static void Main(string[] args)
    {
        

        void Main()
        {
            string userName = PromptUserName();
            int favNum = PromptUserNumber();
            int birthYear = PromptUserBirthYear();
            int favNumSquared = ReturnFavNumSquared(favNum);
            int yearsOld = ReturnYearsOld(birthYear);

            Console.WriteLine("Welcome to the program. It is totally safe here, I promise");
            Console.WriteLine($"Hello {userName}");
            Console.WriteLine($"Your favorite number is: {favNum}");
            Console.WriteLine($"Your birth year is: {birthYear}");
            Console.WriteLine($"Your favorite number {favNum} squared is: {favNumSquared}");
            Console.WriteLine($"{userName}, you will turn {yearsOld} this year");

        }


        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string num = Console.ReadLine();
            int favNum = int.Parse(num);
            return favNum;
        }

        static int PromptUserBirthYear()
        {
            Console.Write("Please enter your birth year: ");
            string byear = Console.ReadLine();
            int birthYear = int.Parse(byear);
            return birthYear;
        }

        static int ReturnFavNumSquared(int number)
        {
            return number * number;
        }

        static int ReturnYearsOld(int year)
        {
            return 2025 - year;
        }

        Main();
    }
}