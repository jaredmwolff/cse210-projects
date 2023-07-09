using System;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        Address address1 = new Address("1567 Rose Ct", "Scranton", "PA", "USA");
        Customer customer1 = new Customer("Michael Scott", address1);
        Product[] products1 = { new Product("World's Best Boss Mug", 1, 5.50, 1), new Product("Box of Paperclips", 2, 3.25, 3) };
        Order order1 = new Order(customer1, products1);

        Console.WriteLine("");
        Console.WriteLine("Order 1:");
        Console.WriteLine("");
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());
        Console.WriteLine("");
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order1.GetShippingLabel());




        ///////////

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("_______________________________");
        Console.WriteLine("");
        Console.WriteLine("");

        ///////////




        Address address2 = new Address("2415 Rainbow St", "Toledo", "OH", "USA");
        Customer customer2 = new Customer("Jane Mare", address2);
        Product[] products2 = { new Product("Acrylic Stand", 3, 19.99, 1), new Product("Pumpkin Spice Scented Candle", 4, 3.99, 3), new Product("Beige Bath Towel", 5, 9.99, 4) };
        Order order2 = new Order(customer2, products2);

        Console.WriteLine("");
        Console.WriteLine("Order 2:");
        Console.WriteLine("");
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());
        Console.WriteLine("");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("");
        Console.WriteLine("");
    }
}