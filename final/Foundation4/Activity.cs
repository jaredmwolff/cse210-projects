public abstract class Activity
{
    private DateTime _date;
    public int _durationInMinutes;

    public Activity(DateTime date, int durationInMinutes)
    {
        this._date = date;
        this._durationInMinutes = durationInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date:d} {GetType().Name} ({_durationInMinutes} min)";
    }
}