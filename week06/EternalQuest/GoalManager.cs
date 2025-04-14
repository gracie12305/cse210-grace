public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordGoal(int index)
    {
        int pointsEarned = _goals[index].RecordEvent();
        _score += pointsEarned;
        Console.WriteLine($"You earned {pointsEarned} points!");
    }

  

    public void ShowGoals()
    {
        

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i].GetName()} - {_goals[i].GetDescription()}");
        }
    }

    public void ShowScore()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public int GoalCount()
{
    return _goals.Count;
}

public void SaveGoalsToFile(string filename)
{
    using (StreamWriter writer = new StreamWriter(filename))
    {
        writer.WriteLine(_score);
        foreach (Goal goal in _goals)
        {
            writer.WriteLine(goal.GetSaveData());
        }
    }
}

public void LoadGoalsFromFile(string filename)
{
    _goals.Clear();
    string[] lines = File.ReadAllLines(filename);
    _score = int.Parse(lines[0]);

    for (int i = 1; i < lines.Length; i++)
    {
        string[] parts = lines[i].Split("|");
        string type = parts[0];
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);

        if (type == "GymGoal")
        {
            bool isComplete = bool.Parse(parts[4]);
            GymGoal goal = new GymGoal(name, description, points);
            if (isComplete)
            {
                goal.RecordEvent(); // set as complete
            }
            _goals.Add(goal);
        }
        else if (type == "TempleVisitationGoal")
        {
            _goals.Add(new TempleVisitationGoal(name, description, points));
        }
        else if (type == "ChecklistGoal")
        {
            int timesCompleted = int.Parse(parts[4]);
            int targetCount = int.Parse(parts[5]);
            int bonus = int.Parse(parts[6]);
            ChecklistGoal goal = new ChecklistGoal(name, description, points, targetCount, bonus);

            for (int j = 0; j < timesCompleted; j++)
                goal.RecordEvent();

            _goals.Add(goal);
        }
    }
}

}

    // Methods for SaveGoals(), LoadGoals() can g