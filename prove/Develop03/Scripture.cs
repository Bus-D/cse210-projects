public class Scripture
{
    Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();
    private string _scripture; // Store scripture text
    // Constructor
    public Scripture(Reference _reference, string _scripture)
    {
        this._reference = _reference;
        this._scripture = _scripture;

        string[] _verseWords = _scripture.Split(' ');
        foreach (string word in _verseWords)
        {
            _words.Add(new Word(word));
        }
    }

    // Getters and Setters
    public string GetSetScripture
    {
        get { return _scripture; }
        set { _scripture = value; }
    }


    // Displays scripture
    public void GetScripture()
    {
        Console.WriteLine("Please enter the text of the verse(s) you would like to memorize. Please don't have verse numbers");
        Console.Write("> ");
        string _verseText = Console.ReadLine();

        char[] delimiters = { ' ', ',', '.', ';', '!', '?' };
        _words = _verseText
            .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
            .Select(word => new Word(word.ToLower()))
            .ToList();
    }

    // Gives number of words that needs to be hidden before the program ends
    public int PEnd()
    {
        return _words.Count;
    }


    public void HideRandomWords(int count)
    {
        var availableWords = _words.Where(w => !w.IsHidden).ToList();
        if (availableWords.Count == 0) return;

        count = Math.Min(count, availableWords.Count);

        for (int i = 0; i < count; i++)
        {
            int randomIndex = _random.Next(0, availableWords.Count);
            availableWords[randomIndex].Hide();
            availableWords.RemoveAt(randomIndex);
        }
    }
    public int AddHidden()
    {
        int _hiddenCount = 0;
        foreach (Word _word in _words)
        {
            if (_word.IsHidden)
                _hiddenCount++;
        }
        return _hiddenCount;
    }

    // Ends program if all words are hidden
    public bool AllWordsHidden()
    {
        return AddHidden() == PEnd();
    }

    public void Display()
    {
        foreach (Word word in _words)
        {
            Console.Write(word.ReplaceWord() + " ");
        }
        Console.WriteLine();
    }
    
}