public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        _isComplete = false;
    }

    public void SetIsComplete(bool IsComplete)
    {
        _isComplete = IsComplete;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string goalString = $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
        return goalString;
    }
}