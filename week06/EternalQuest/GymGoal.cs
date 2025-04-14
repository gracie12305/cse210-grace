public class GymGoal : Goal
{
    public GymGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        return _points; // never complete, always earn points
    }

    public override string GetStatus()
    {
        return "[∞]"; // or something like "[ ]" with a label
    }

    public override string GetSaveData()
    {
        return $"EternalGoal|{_name}|{_description}|{_points}";
    }
}