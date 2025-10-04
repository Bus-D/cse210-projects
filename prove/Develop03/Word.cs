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

    public bool GetHidden
    {
        get { return _isHidden; }
    }

    public void IsHidden()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public string ReplaceWord()
    {
        if (_isHidden)
        {
            return new string('_', _word.Length);
        }
        else
        {
            return _word;
        }
    }
}