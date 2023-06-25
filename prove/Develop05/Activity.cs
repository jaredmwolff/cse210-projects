public abstract class Activity
{
    public string _name;
    public string _description;
    public int _pointValue;


    public abstract bool IsComplete();
    public abstract int RecordEvent();



    //public string Name
    //{
    //    get { return name; }
    //    set { name = value; }
    //}

    //public int PointValue
    //{
    //    get { return pointValue; }
    //    set { pointValue = value; }
    //}

    //public Activity(string name, int pointValue)
    //{
    //    this.name = name;
    //    this.pointValue = pointValue;
    //}

    //public virtual string DisplayProgress()
    //{
    //    return $"Activity: {name}, Points: {pointValue}";
    //}
}