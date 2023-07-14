public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(DateTime date, int howManyMinutes, int laps) : base(date, howManyMinutes)
    {
        this._laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _howManyMinutes * 60;
    }

    public override double GetPace()
    {
        return _howManyMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}: Distance {GetDistance():f1} km, Speed: {GetSpeed():f1} kph, Pace: {GetPace():f1} min per km";
    }
}