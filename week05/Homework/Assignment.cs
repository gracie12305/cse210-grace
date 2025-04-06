using System.Xml.Serialization;

ImportContext importContext;

public class Assignment
{
    private string _studentName;
    private string _topic;
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentName+"_"+ _topic;
    }
}