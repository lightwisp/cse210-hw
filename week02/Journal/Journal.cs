using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    
    public List<Entry> _enteries;
    
    public void AddToJournal(Entry newEntry)
    {
        _enteries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry input in _enteries)
        {
            input.Display();
        }
    }
    public void SaveToFile(List<Entry> _enteries, string file)
    {
        
        Console.WriteLine("Saving to file...");
        Console.WriteLine($"Saving file to: {Path.GetFullPath(file)}");
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (Entry line in _enteries)
            {   
                writer.WriteLine($"{line._date},{line._promptText},{line._enteryText}");
            }
        }
    }

    public string LoadFormFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string _date = parts[0];
            string _promptText = parts[1];
            string _enteryText = parts[2];
            Entry entry = new Entry()
            {
            _date = _date,
            _promptText = _promptText,
            _enteryText = _enteryText
            };
            AddToJournal(entry);
        }
        Console.WriteLine("File has been loaded...");
        return null;
    }
}