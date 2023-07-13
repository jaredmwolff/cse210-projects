public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(DateTime date, int durationInMinutes, int laps) : base(date, durationInMinutes)
    {
        this._laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _durationInMinutes * 60;
    }

    public override double GetPace()
    {
        return _durationInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}: Distance {GetDistance():f1} km, Speed: {GetSpeed():f1} kph, Pace: {GetPace():f1} min per km";
    }
}