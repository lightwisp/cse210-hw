
public class PromtGeneratir
{
    public List<string> _prompts = new List<string>
    {
        "What are you grateful for today?",
        "Describe your perfect day.",
        "What challenges did you face today and how did you overcome them?",
        "What is one thing you learned recently?",
        "Write about a memory that makes you happy.",
        "What are your goals for tomorrow?",
        "Who is someone that inspires you and why?"
    };

    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randNum = random.Next(0, _prompts.Count);
        Console.WriteLine(_prompts[randNum]);
        string newPrompt = _prompts[randNum];
        return newPrompt;
    }
}