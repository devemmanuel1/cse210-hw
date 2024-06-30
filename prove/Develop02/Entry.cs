public class Entry 
{
    public string _date;
    public string _dayOfWeek;
    public string _promptText;
    public string _entryText;


    public void Display() 
    {
        Console.WriteLine();
        Console.WriteLine($"Date: {_date} ({_dayOfWeek}) - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}