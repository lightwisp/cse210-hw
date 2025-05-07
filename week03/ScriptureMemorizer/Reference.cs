
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Reference
{
    private string _bookSet;
    private string _book;
    private int _chapter;
    private int _verse;
    private int _startVerse;
    private int _endVerse;
    
    public int BookSetGet()
    {
        int soulution = 0;
        while (soulution < 1 || soulution > 5)
        {  
            Console.WriteLine("What Colection is your scrripter in?");
            Console.WriteLine("1: Old Testament\n2: New Testament\n3: Book of Mormon\n4: Doctrine and Covenants\n5: Pearl of Great Price");
            string answer = Console.ReadLine();
            soulution = int.Parse(answer);
            if (soulution < 1 || soulution > 5)
            {
                Console.Clear();
                Console.WriteLine("Select a valid option.");  
            }
            
        }
        return soulution;
    }
    public void BookSetLink(int soulution)
    {     
        switch(soulution)
        {
            case 1:
                _bookSet = "https://www.churchofjesuschrist.org/study/scriptures/ot";
                break;
            case 2:
                _bookSet = "https://www.churchofjesuschrist.org/study/scriptures/nt";
                break;
            case 3:
                _bookSet = "https://www.churchofjesuschrist.org/study/scriptures/bofm";
                break;
            case 4:
                _bookSet = "https://www.churchofjesuschrist.org/study/scriptures/dc-testament";
                break;
            case 5:
                _bookSet = "https://www.churchofjesuschrist.org/study/scriptures/pgp";
                break;
        }
        Console.WriteLine("Go ahead and find your scripture on the churches website.\nThis is so you can copy and past the verse into the program.\n");
        Console.WriteLine("Hold 'Ctrl' and click on the link.");
        Console.WriteLine(_bookSet);
    }
    public void SingleReference(string book, int chapter, int verse)
    {   
        _book = book;
        
        _chapter = chapter;
        
        _verse = verse;
    }
    public void MultipleReference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        
        _chapter = chapter;
        
        _startVerse = startVerse;
        
        _endVerse = endVerse;
    } 
    public bool SingleOrMulti()
    {
        bool oneOrMore = false;
        int answer = 0;
        while(answer != 1 || answer != 2)
        {
            Console.WriteLine("Do you want to memorize more than one verse at a time?\n1: Yes\n2: No");
            answer = int.Parse(Console.ReadLine());
            if(answer == 1)
            {
                Console.Clear();
                oneOrMore = true;
                break;
            }
            else if(answer < 1 || answer > 2)
            {
                Console.Clear();
                Console.WriteLine("Select a valid option.");  
            }
            else
            {
                Console.Clear();
                oneOrMore = false;
                break;
            }
        }
        return oneOrMore;
    }
    public string GetDisplayText()
    {  
        string scripterRefrence = "";
        if (_endVerse != default)
        {
            scripterRefrence = $"{_book} {_chapter}: {_startVerse}-{_endVerse}";     
        }
        else
        {
            scripterRefrence = $"{_book} {_chapter}: {_verse}";
        }
        return scripterRefrence;
    }
}