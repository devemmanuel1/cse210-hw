public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public string DisplayFullDetails()
    {
        string details = "";
        details += DisplayStandardDetails();
        details += $"  Event Type: Reception\n";
        details += $"  RSVP Email Address: {_email}\n";

        return details;
    }

    public string DisplayShortDescription()
    {
        string details = "";
        details += $"  Event Type: Reception\n";
        details += $"  Title: {GetTitle()}\n";
        details += $"  Date: {GetDate()}\n";

        return details;
    }
}