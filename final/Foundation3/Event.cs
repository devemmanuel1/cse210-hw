
public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDate()
    {
        return _date;
    }

    public string DisplayStandardDetails()
    {
        string details = "";
        details += $"  Title: {_title}\n";
        details += $"  Description: {_description}\n";
        details += $"  Date: {_date}\n";
        details += $"  Time: {_time}\n";
        details += $"  Address: \n{_address.ToStringAddress()}\n";

        return details;
    }
}
