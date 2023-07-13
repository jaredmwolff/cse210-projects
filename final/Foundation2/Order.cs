using System;

public class Order
{
    private Customer _customer;
    private Product[] _products;
    private const double USA_SHIPPING_COST = 5;
    private const double INTERNATIONAL_SHIPPING_COST = 35;

    public Order(Customer customer, Product[] products)
    {
        this._customer = customer;
        this._products = products;
    }

    public double GetTotalCost()
    {
        double totalCost = 0;

        foreach (Product product in this._products)
        {
            totalCost += product.GetPrice();
        }


        if (this._customer.InUSA())
        {
            totalCost += USA_SHIPPING_COST;
        }

        else
        {
            totalCost += INTERNATIONAL_SHIPPING_COST;
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (Product product in this._products)
        {
            packingLabel += $"{product.GetName()}, Product ID: {product.GetProductId()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"{this._customer.GetName()}\n{this._customer.GetAddress().GetFullAddress()}";
    }
}