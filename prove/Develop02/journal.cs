using System.IO;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

public class Journal
{
    public List<string> _entries = new List<string> { };
    // Save Entry

    public string _filePath;

    public void AddEntry(Entry entry)
    {
        string newEntry = entry.EntryCollection();
        _entries.Add(newEntry);
    }

    public void MakeNewFileLocation()
    {
        Console.Write("Where do you want to write the entry? ");
        _filePath = Console.ReadLine();

    }

    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet.\n");
            return;
        }

        Console.WriteLine("\n--- Journal Entries ---");
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
        Console.WriteLine("------------------------\n");
    }

    public void Save()
    {

        Console.WriteLine("Where do you want to save?");

        _filePath = Console.ReadLine();

        try
        {
            using (StreamWriter output = new StreamWriter(_filePath, false))
            {
                foreach (string entry in _entries)
                {
                    output.WriteLine($"{entry}");
                }
            }
            Console.WriteLine($"Saved to {_filePath}.");
            Console.WriteLine("");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"An error occurredL {ex.Message}");
        }
    }



    public void Load()
    {
        Console.Write("Which journal would you like to load? ");
        _filePath = Console.ReadLine();

        if (File.Exists(_filePath))
        {
            _entries = File.ReadAllLines(_filePath).ToList();
            Console.WriteLine("Journal loaded!\n");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    } 
}
    

    
