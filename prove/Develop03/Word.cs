using System.Reflection.Metadata.Ecma335;

public class Word
{
    private string _word;
    private bool _isHidden = false;

    public Word(string word)
    {
        _word = word;
    }

    public string GetSetWord
    {
        get { return _word; }
    }

    public bool IsHidden
    {
        get { return _isHidden; }
        set { _isHidden = value; }
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public string ReplaceWord()
    {
        return _isHidden ? new string('_', _word.Length) : _word;
    }
}