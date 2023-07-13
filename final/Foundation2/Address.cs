using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        this._streetAddress = streetAddress;
        this._city = city;
        this._stateOrProvince = stateOrProvince;
        this._country = country;
    }

    public bool InUSA()
    {
        return this._country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public string GetFullAddress()
    {
        return $"{this._streetAddress}\n{this._city}, {this._stateOrProvince} {this._country}";
    }
}