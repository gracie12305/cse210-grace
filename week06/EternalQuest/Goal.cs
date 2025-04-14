public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    } 
    public string GetDescription()
    {
        return _description;
    }

    
    public abstract int RecordEvent(); // returns points earned
    public abstract string GetStatus(); // e.g., [X] or Completed 3/5
    public abstract string GetSaveData(); // For saving to file
}