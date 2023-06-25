public class SimpleGoal : Activity
{
    public bool _completed;
    public override bool IsComplete()
    {
        return _completed;
    }

    //public SimpleGoal(string name, int pointValue) : base(name, pointValue)
    //{
    //    this._completed = false;
    //}

    public override int RecordEvent()
    {
        if (!_completed)
        {
            _completed = true;
            return _pointValue;
        }

        return 0;
    }

    //public override string DisplayProgress()
    //{
    //    string completionStatus = _completed ? "[x]" : "[ ]";
    //    return $"{completionStatus} Activity: {Name}, Points: {PointValue}";
    //}
}
