public class LapSwimming : Activity
{
    private double _numberOfLaps;

    public LapSwimming(string date, double length, double numberOfLaps) : base(date, length)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double CalculateDistance()
    {
        return _numberOfLaps * 50 / 1000 * 0.62;
    }

    public override double CalculateSpeed()
    {
        return CalculateDistance() / GetLength() * 60;
    }

    public override double CalculatePace()
    {
        return 60 / CalculateSpeed();
    }

    public override string GetEventType()
    {
        return "Lap Swimming";
    }
}