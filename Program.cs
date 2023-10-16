using System;
using System.Collections.Generic;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public int Rating { get; set; }
}

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public List<Order> PurchaseHistory { get; set; }
}

public class Order
{
    public List<Product> Products { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
    public string OrderStatus { get; set; }
}

public interface ISearchable
{
    List<Product> SearchByPrice(decimal price);
    List<Product> SearchByCategory(string category);
    List<Product> SearchByRating(int rating);
}

public class Store : ISearchable
{
    public List<User> Users { get; set; }
    public List<Product> Products { get; set; }
    public List<Order> Orders { get; set; }

    public List<Product> SearchByPrice(decimal price)
    {
        List<Product> result = new List<Product>();
        foreach (var product in Products)
        {
            if (product.Price == price)
            {
                result.Add(product);
            }
        }
        return result;
    }

    public List<Product> SearchByCategory(string category)
    {
        List<Product> result = new List<Product>();
        foreach (var product in Products)
        {
            if (product.Category == category)
            {
                result.Add(product);
            }
        }
        return result;
    }

    public List<Product> SearchByRating(int rating)
    {
        List<Product> result = new List<Product>();
        foreach (var product in Products)
        {
            if (product.Rating >= rating)
            {
                result.Add(product);
            }
        }
        return result;
    }
}
