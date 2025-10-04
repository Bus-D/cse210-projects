public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    // Constructor
    public Scripture(string _reference, string _scripture)
    {

        this._reference = new Reference(_reference);

        string[] _verseWords = _scripture.Split(" ");
        int _randomNumber = _random.Next(_verseWords.Length);
    }

    // Displays scripture
    public void DisplayScripture()
    {
        
    }

    // Gives number of words that needs to be hidden before the program ends
    public int PEnd()
    {
        return _words.Count;
    }

    // Hides random words: defaults to 3
    public void HideRandomWords(int _variableName = 3)
    {

    }

    // Adds the number of words hidden together, checks against the number of words in the scripture
    public int AddInt()
    {

    }

    // Ends program if all words are hidden
    public bool AllWordsHidden()
    {

    }
    
}