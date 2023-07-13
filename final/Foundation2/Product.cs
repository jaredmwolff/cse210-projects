using System;

public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        this._name = name;
        this._productId = productId;
        this._price = price;
        this._quantity = quantity;
    }

    public double GetPrice()
    {
        return this._price * this._quantity;
    }

    public string GetName()
    {
        return this._name;
    }

    public int GetProductId()
    {
        return this._productId;
    }

    public int GetQuantity()
    {
        return this._quantity;
    }
}