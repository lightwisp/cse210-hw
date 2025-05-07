
class Scriptures 
{
    private List<string> _words = new List<string>();
    private Reference _reference;
    private string _originalText;
    Word word = new Word();
    HashSet<int> usedIndex = new HashSet<int>();
    Random random = new Random();
    public int WordsCount
    {
        get {return _words.Count;}
    }
    public void Scripture(Reference reference, string text)
    {
        _originalText = text;
        _words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
        Console.WriteLine(reference.GetDisplayText() + "\n" + _originalText);   
    }
    public void HideRandomeWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int randIndex;
            do
            {
                randIndex = random.Next(0, WordsCount);
            } while (usedIndex.Contains(randIndex));
            usedIndex.Add(randIndex);
            word.WordInList(_words[randIndex]);
            _words[randIndex] = word.Hide();
        }
    }
    public string GetDisplayText()
    {
        string stringTogether = "";
        foreach (string word in _words)
        {
            stringTogether += word + " ";
        }
        return stringTogether;
    }
    public bool IsCompletelyHidden()
    {
        //make this for the next step. must recognize when all words are hidden and then go to the next step.
        bool placholder = false;
        return placholder;
    }
}