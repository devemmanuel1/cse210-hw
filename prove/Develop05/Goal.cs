public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public string GetGoalName()
    {
        return _shortName;
    }

    // Abstract method for recording a completed event
    public abstract int RecordEvent();

    // Abstraction method for returning if a goal is complete or not
    public abstract bool IsComplete();

    // Virtual method for listing the details of a goal
    public virtual string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[X] {_shortName} ({_description})";
        }
        else 
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }

    // Abstract method for getting a string to save to a file
    public abstract string GetStringRepresentation();
}