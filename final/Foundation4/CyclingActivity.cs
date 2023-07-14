public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(DateTime date, int howManyMinutes, double speed) : base(date, howManyMinutes)
    {
        this._speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * _howManyMinutes / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()}: Distance {GetDistance():f1} km, Speed: {_speed:f1} kph, Pace: {GetPace():f1} min per km";
    }
}