using System;
using Shared.DDD;


namespace Catalog.Products.Models;

public class Product : Entity<Guid>
{
    public string Name { get; set; } = default;
    public List<string> Category { get; set; } = new();

    public string Description { get; set; } = default;
    public string ImageFile { get; set; } = default;
    public decimal Price { get; set; }
}
public static Product Create(Guid id, string name, List<string> category, string description, string imageFile, decimal price)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price);
        var product = new Product
        {
            Id = id, 
            Name = name,
            Category = category,
            Description = description,
            ImageFile = imageFile,
            Price = price

        }
        product.AddDomainEvent(new ProductPriceChangeEvent(product));
        return product;
    }
    public static Product Update(Guid id, string name, List<string> category, string description, string imageFile, decimal price)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(price);
        var product = new Product
        {
            Id = id,
            Name = name,
            Category = category,
            Description = description,
            ImageFile = imageFile,
            Price = price

        }
     if(product.Price != price)
        {
            product.AddDomainEvent(new ProductPriceChangeEvent(product));
        }
        return product;

    }