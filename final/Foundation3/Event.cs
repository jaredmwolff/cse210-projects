using System;

public class Event
{
    private string _title;
    private string _description;
    private DateTime _dateTime;
    private Address _address;

    public Event(string title, string description, DateTime dateTime, Address address)
    {
        this._title = title;
        this._description = description;
        this._dateTime = dateTime;
        this._address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"{_title} - {_description}\nDate: {_dateTime.ToShortDateString()}\nTime: {_dateTime.ToShortTimeString()}\nAddress: {_address.GetAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"{_title} - {_dateTime.ToShortDateString()}";
    }
}