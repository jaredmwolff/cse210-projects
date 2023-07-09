using System;

public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool InUSA()
    {
        return this.address.InUSA();
    }

    public string GetName()
    {
        return this.name;
    }

    public Address GetAddress()
    {
        return this.address;
    }
}