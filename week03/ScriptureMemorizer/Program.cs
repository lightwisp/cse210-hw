using System;

class Program
{
    static string GetInfo(Reference reference)
    {
        string text = "";
        bool singleOrMulti = reference.SingleOrMulti();
        reference.BookSetLink(reference.BookSetGet());
        if (singleOrMulti)
        {   
            Console.WriteLine("What is the Book's name?");
            string book = Console.ReadLine();
            Console.WriteLine("What is the chapter number?");
            int chapter = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your starting verse number?");
            int startVerse = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the last verse number?");
            int endVerse = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the entier content of the verses?");
            text = Console.ReadLine();
            reference.MultipleReference(book, chapter, startVerse, endVerse);
        }
        else if(singleOrMulti == false)
        {
            Console.WriteLine("What is the Book name?");
            string book = Console.ReadLine();
            Console.WriteLine("What is the chapter number?");
            int chapter = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the verse number?");
            int verse = int.Parse(Console.ReadLine());
            Console.WriteLine("Copy the scripture from the church's web site with 'Ctrl + C'\nThen past it into the console with'Ctrl + Shift + V'\n");
            Console.WriteLine("What is the entier content of the verse?");
            text = Console.ReadLine();
            reference.SingleReference(book, chapter, verse);
        }
        return text;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Scriptures scriptures = new Scriptures();
        Reference reference = new Reference();
        Word word = new Word();

        scriptures.Scripture(reference, GetInfo(reference));
        
        int numberToHide;
        do
        {
            Console.WriteLine("How many numbers would you like to hide every loop?");
            string hideAmount = Console.ReadLine();
            if (int.TryParse(hideAmount, out numberToHide))
            {
                break;
            }
            else
            {
                Console.WriteLine("Use a valid Number");
            }
        } while (true);
        
        string on = "";
        while (on != "Quit")
        {   
            Console.Clear();

            reference.GetDisplayText();
            scriptures.GetDisplayText();

            scriptures.HideRandomeWords(numberToHide);

            Console.WriteLine();
            Console.WriteLine("Type 'Quit' to Exit.");
            Console.WriteLine();

            string answer = Console.ReadLine();
            on = answer.ToUpper();
        }
    }
}