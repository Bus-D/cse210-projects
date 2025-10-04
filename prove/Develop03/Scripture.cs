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
        List<string> _words = _verseText.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Select(word => word.ToLower()).ToList();
    }

    // Gives number of words that needs to be hidden before the program ends
    public int PEnd()
    {
        return _words.Count;
    }

    // Hides random words: defaults to 3
    public void HideRandomWords(int _variableName = 3)
    {
        for (int i = 0; i < PEnd(); i++)
        {
            int randomIndex = _random.Next(0, _words.Count);

            Word _word = _words[randomIndex];

            if (!_word.GetHidden)
            {
                _word.IsHidden();
            }
        }
    }

    // Adds the number of words hidden together, checks against the number of words in the scripture
    public int AddHidden()
    {

        int _hiddenCount = 0;

        foreach (Word _word in _words)
        {
            _hiddenCount++;
        }
        return _hiddenCount;
    }

    // Ends program if all words are hidden
    public bool AllWordsHidden(bool toggle)
    {
        if (AddHidden() == PEnd())
        {
            toggle = true;
            return toggle;
        }
        return toggle;
    }

    public void Display()
    {
        bool toggle = false;
        
        GetScripture();
        PEnd();
        AddHidden();
        AllWordsHidden(toggle);
    }
    
}