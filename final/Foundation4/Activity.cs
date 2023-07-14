public abstract class Activity
{
    private DateTime _date;
    public int _howManyMinutes;

    public Activity(DateTime date, int howManyMinutes)
    {
        this._date = date;
        this._howManyMinutes = howManyMinutes;
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
        return $"{GetType().Name} on {_date:d} ({_howManyMinutes} min)";
    }
}