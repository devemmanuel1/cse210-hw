public abstract class Goal(string shortName, string description, int points)
{
    protected string _shortName = shortName;
    protected string _description = description;
    protected int _points = points;

    public string GetGoalName()
    {
        return _shortName;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

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

    public abstract string GetStringRepresentation();
}