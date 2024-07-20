public class Activity
{
    private string _date;
    private double _length;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public double GetLength()
    {
        return _length;
    }

    public virtual double CalculateDistance()
    {
        return 0;
    }

    public virtual double CalculateSpeed()
    {
        return 0;
    }

    public virtual double CalculatePace()
    {
        return 0;
    }

    public virtual string GetEventType()
    {
        return "Event Type";
    }

    public string GetSummary()
    {
        string summary = "";
        summary += _date;
        summary += $" {GetEventType()} ";
        summary += $"({_length} min)";
        summary += $" - Distance: {CalculateDistance():F1} miles, ";
        summary += $"Speed: {CalculateSpeed():F1} mph, ";
        summary += $"Pace: {CalculatePace():F1} min per mile";

        return summary;
    }
}