public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(DateTime date, int durationInMinutes, double distance) : base(date, durationInMinutes)
    {
        this._distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _durationInMinutes * 60;
    }

    public override double GetPace()
    {
        return _durationInMinutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}: Distance {_distance:f1} miles, Speed {GetSpeed():f1} mph, Pace: {GetPace():f1} min per mile";
    }
}