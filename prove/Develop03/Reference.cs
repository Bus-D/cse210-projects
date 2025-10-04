public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;
    private string _fullReference;
    private bool _isAll = true; // Have user choose is they want to read all verses in a reference (1-10) or specific verses (1, 10)

    // Constructors
    public Reference(string _book, int _chapter, int _verseStart)
    {
        this._book = _book;
        this._chapter = _chapter;
        this._verseStart = _verseStart;
    }

    public Reference(string _book, int _chapter, int _verseStart, int _verseEnd)
    {
        this._book = _book;
        this._chapter = _chapter;
        this._verseStart = _verseStart;
        this._verseEnd = _verseEnd;
    }

    // Getters and Setters
    // Got simplified get set syntax from google search
    public string Book
    {
        get { return _book; }
        set { _book = value; }
    }

    public int Chapter
    {
        get { return _chapter; }
        set { _chapter = value; }
    }

    public int VerseStart
    {
        get { return _verseStart; }
        set { _verseStart = value; }
    }
    public int VerseEnd
    {
        get { return _verseEnd; }
        set { _verseEnd = value; }
    }

    public bool IsAll
    {
        get { return _isAll; }
        set { _isAll = false; }
    }

    public string FullReference
    {
        get { return _fullReference; }
        set { _fullReference = value; }
    }




    // Display
    public void GetReference()
    {
        Console.WriteLine("Welcome to the Scripture Memorizeor Program!");

        {
            Console.WriteLine("Please enter the book and chapter of the scripture you want to memorize. (ex. 1 Nephi 1)");
            Console.Write("> ");
            string _chapRef = Console.ReadLine();
            Console.WriteLine("");
            string[] _refSplit = _chapRef.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (_refSplit.Length == 3)
            {

                Book = _refSplit[0] + " " + _refSplit[1];
                Chapter = int.Parse(_refSplit[2]);
            }
            else if (_chapRef.Split(' ').Length == 2)
            {
                Book = _refSplit[0];
                Chapter = int.Parse(_refSplit[1]);
            }
            else
            {
                Console.WriteLine("Invaild input format");
            }

            Console.WriteLine("Please enter the verse(s) of the scripture you want to memorize. (ex. 3(-5))");
            Console.Write("> ");
            string _verse = Console.ReadLine();
            Console.WriteLine("");
            bool _multVerse = _verse.Contains("-");

            if (_multVerse)
            {

                string[] _verseSplit = _verse.Split('-');
                _verseStart = int.Parse(_verseSplit[0]);
                _verseEnd = int.Parse(_verseSplit[1]);

                IsAll = true;
            }
            else
            {
                _verseStart = int.Parse(_verse);
                IsAll = false;
            }
        }
    }

    public string IsReady()
    {
        GetReference();
        bool _isReady = false;

        while (!_isReady)
        {
            if (IsAll)
            {
                Console.WriteLine($"The reference is: {Book} {Chapter}: {VerseStart}-{VerseEnd}");
                Console.WriteLine("Is this correct? Y/N");
                string _correct = Console.ReadLine();
                string _isCorrect = _correct.Trim().ToLower();

                if (_isCorrect == "y")
                {
                    FullReference = $"{Book} {Chapter}: {VerseStart}-{VerseEnd}";
                    _isReady = true;
                }
                else
                {
                    GetReference();
                    return "";
                }
            }
            else
            {
                Console.WriteLine($"The reference is: {Book} {Chapter}: {VerseStart}");
                Console.WriteLine("Is this correct? Y/N");
                string _correct = Console.ReadLine();
                string _isCorrect = _correct.Trim().ToLower();

                if (_isCorrect == "y")
                {
                    FullReference = $"{Book} {Chapter}: {VerseStart} ";
                    _isReady = true;
                }
                else
                {
                    GetReference();
                    return "";
                }
            }
            return "";
        }
        return FullReference;
    }
}
