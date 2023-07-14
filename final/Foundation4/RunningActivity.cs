public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(DateTime date, int howManyMinutes, double distance) : base(date, howManyMinutes)
    {
        this._distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _howManyMinutes * 60;
    }

    public override double GetPace()
    {
        return _howManyMinutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}: Distance {_distance:f1} miles, Speed {GetSpeed():f1} mph, Pace: {GetPace():f1} min per mile";
    }
}