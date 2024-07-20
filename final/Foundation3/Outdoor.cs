public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public string DisplayFullDetails()
    {
        string details = "";
        details += DisplayStandardDetails();
        details += "  Event Type: Outdoor Gathering\n";
        details += $"  Weather Forecast: {_weatherForecast}\n";

        return details;
    }

    public string DisplayShortDescription()
    {
        string details = "";
        details += "  Event Type: Outdoor Gathering\n";
        details += $"  Title: {GetTitle()}\n";
        details += $"  Date: {GetDate()}\n";

        return details;
    }
}