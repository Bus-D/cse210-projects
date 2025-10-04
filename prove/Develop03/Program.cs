using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string word = "";
        int _chapter = 0;
        int _verseStart = 0;
        int _verseEnd = 0;
        string _book = "";
        string scripture = "";

        Reference _reference = new Reference(_book, _chapter, _verseStart, _verseEnd);
        Word _word = new Word(word);
        Scripture _scripture = new Scripture(_reference, scripture);

        bool _quit = false;

        while (!_quit)
        {
            _reference.IsReady();
            _scripture.Display();
        }

    }
    

    

}