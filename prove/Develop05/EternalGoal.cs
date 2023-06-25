public class EternalGoal : Activity
{

    //public EternalGoal(string name, int pointValue) : base(name, pointValue) {}

    public override bool IsComplete()
    {
        return false;
    }

    public override int RecordEvent()
    {
        return _pointValue;
    }
}
