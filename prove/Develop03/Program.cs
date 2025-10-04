using System;

class Program
{
    static void Main(string[] args)
    {

        Reference _reference = new Reference("", 0, 0, 0);
        Scripture _scripture = new Scripture(_reference, "");

        Console.Clear();
        bool _quit = false;

        Console.WriteLine("Welcome to the Scripture Memorizeor Program!");
        _reference.IsReady();
        _scripture.GetScripture();

        while (!_quit)
        {

            _reference.DisplayRef();
            _scripture.Display();

            Console.WriteLine("\nPress Enter to hide more words, or type quit to exit:");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
            {
                _quit = true;
            }
            else
            {
                _scripture.HideRandomWords(3);
            }
        }

    }
    

    

}