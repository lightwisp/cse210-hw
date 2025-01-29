
class Word
{
    private string _text;
    private bool _isHidden;
    public void WordInList(string text)
    {  
        _text = text;
    }
    public string Hide()
    {
        // c = char
        string underScore = string.Concat(_text.Select(c => char.IsLetter(c) ? "_" : (char.IsDigit(c) || ",:.':".Contains(c) ? c.ToString() : " ")));
        return underScore;
    }
    public void Show(string originalText)
    {
        
    }
    public bool IsHidden()
    {
        bool placholder = false;
        return placholder;
    }
    public string GetDisplayText()
    {   
        return null;
    }
}