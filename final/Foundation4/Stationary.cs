public class Stationary : Activity
{
    private double _speed;

    public Stationary(string date, double length, double speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return GetLength() / CalculatePace();
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculatePace()
    {
        return 60 / _speed;
    }

    public override string GetEventType()
    {
        return "Stationary Bicycling";
    }
}