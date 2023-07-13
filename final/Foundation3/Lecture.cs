using System;
public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, DateTime dateTime, Address address, string speakerName, int capacity) : base(title, description, dateTime, address)
    {
        this._speakerName = speakerName;
        this._capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nSpeaker: {_speakerName}\nCapacity: {_capacity}";
    }
}