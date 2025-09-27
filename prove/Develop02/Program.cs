using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;


// Exceeding Requirements: 
// In addition to the required features, each entry also stores a "Location" along with the Date and Response.
// This adds more context to the journal entries and provides additional information beyond the base specification.

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        bool _run = true;

        while (_run)
        {
            Console.WriteLine(
            "\n1. Write an Entry\n" +
            "2. Display\n" +
            "3. Load\n" +
            "4. Save\n" +
            "5. Quit\n"
        );

            string option = Console.ReadLine();
            Console.WriteLine("");
            int choice = int.Parse(option);

            switch (choice)
            {
                case 1:
                    Entry entry = new Entry();
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    journal.Load();
                    break;
                case 4:
                    journal.Save();
                    break;
                case 5:
                    _run = false;
                    break;
                default:
                    Console.WriteLine("Invalid Input. Please enter a valid input");
                    break;

            }
        }



    }
}