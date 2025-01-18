
using System;
using System.Formats.Asn1;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{   
    static string FileGet()
    {
        Console.WriteLine("What is the file name? ");
        Console.WriteLine("Example: MyJornal");
        string input = Console.ReadLine();
        string file_name = $@"C:\Users\sayer\Desktop\CSE 210programming with Classes\cse210-hw\week02\Journal\{input}";
        return file_name;
    }
    static int DisplayMenu()
    {
        Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("What would you like to do? ");
        string answer = Console.ReadLine();
        int input = int.Parse(answer);
        return input;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        DateTime now = DateTime.Now;

        Journal journal = new Journal();
        journal._enteries = new List<Entry>();

        PromtGeneratir promtGeneratir = new PromtGeneratir();
        

        Entry entry = new Entry();
        
        bool on = true;
        while (on)
        {
            int answer = DisplayMenu();

            switch(answer)
            {
                case 1:
                    string curent_prompt = promtGeneratir.GetRandomPrompt();
                    entry._date = now.ToString("M/d/yyyy"); 
                    entry = new Entry 
                    {
                        _date = now.ToString("M/d/yyyy"),
                        _promptText = curent_prompt,
                        _enteryText = Console.ReadLine()
                    };
                    journal._enteries.Add(entry);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    string file_serch = FileGet();
                    journal.LoadFormFile(file_serch);
                    break;
                case 4:
                    string file_save = FileGet();
                    journal.SaveToFile(journal._enteries, file_save);
                    break;
                case 5:
                    Console.WriteLine("Good Bye");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Option, pick a number.");
                    break;
            }

            
        }
    }
}