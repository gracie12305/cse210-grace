public class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted == _targetCount)
            return _points + _bonus;
        else
            return _points;
    }

    public override string GetStatus()
    {
        return $"Completed {_timesCompleted}/{_targetCount}";
    }

    public override string GetSaveData()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_timesCompleted}|{_targetCount}|{_bonus}";
    }
}