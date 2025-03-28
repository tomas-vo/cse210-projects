using System;
using System.Collections.Generic;

public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public bool IsUSA()
    {
        return country.ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}

public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool LivesInUSA()
    {
        return address.IsUSA();
    }

    public string GetName()
    {
        return name;
    }

    public Address GetAddress()
    {
        return address;
    }
}

public class Product
{
    private string name;
    private string productId;
    private decimal price;
    private int quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return price * quantity;
    }

    public string GetName()
    {
        return name;
    }

    public string GetProductId()
    {
        return productId;
    }
}

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }

        decimal shippingCost = customer.LivesInUSA() ? 5 : 35;
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (var product in products)
        {
            label += $"Product: {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creating address and customer
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        // Creating order and adding products
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P123", 1000, 1));
        order1.AddProduct(new Product("Mouse", "P456", 20, 1));

        // Displaying packing label, shipping label and total cost
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"\nTotal Order Price: ${order1.CalculateTotalCost():F2}");
    }
}
