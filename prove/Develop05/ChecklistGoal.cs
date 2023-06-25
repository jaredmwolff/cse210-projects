public class ChecklistGoal : Activity
{
    public int _numTimesCompleted;
    public int _numTimesRequired;
    public int _bonusPoints;

    public ChecklistGoal(int numTimesRequired, int bonusPoints)
    {
        this._numTimesCompleted = 0;
        this._numTimesRequired = numTimesRequired;
        this._bonusPoints = bonusPoints;
    }

    public override int RecordEvent()
    {
        _numTimesCompleted++;

        if (_numTimesCompleted == _numTimesRequired)
        {
            return _pointValue + _bonusPoints;
        }

        return _pointValue;
    }

    public override bool IsComplete()
    {
        return _numTimesCompleted >= _numTimesRequired;
    }

    //public override string DisplayProgress()
    //{
    //    return $"Activity: {Name}, Points: {PointValue}, Completed: {numTimesCompleted}/{numTimesRequired}";
    //}
}


















