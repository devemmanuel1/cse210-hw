public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string DisplayFullDetails()
    {
        string details = "";
        details += DisplayStandardDetails();
        details += $"  Event Type: Lecture\n";
        details += $"  Speaker: {_speaker}\n";
        details += $"  Capacity: {_capacity}\n";

        return details;
    }

    public string DisplayShortDescription()
    {
        string details = "";
        details += $"  Event Type: Lecture\n";
        details += $"  Title: {GetTitle()}\n";
        details += $"  Date: {GetDate()}\n";

        return details;
    }
}