using System; 

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _zipCode;

    public Address(string streetAddress, string city, string state, string zipCode)
    {
        this._streetAddress = streetAddress;
        this._city = city;
        this._state = state;
        this._zipCode = zipCode;
    }

    public string GetAddress()
    {
        return $"{_streetAddress}, {_city}, {_state} {_zipCode}";
    }
}