
public class Entry 
{
    
    public string _date;
    public string _promptText;
    public string _enteryText;

    public void Display()
    {
        Console.WriteLine($"\nDate: {_date}\nPrompt: {_promptText}\nEntery: {_enteryText}\n");
    }
}