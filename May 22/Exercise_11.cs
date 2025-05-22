using System;

class Product
{ 
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main()
    {
       List<Product> products = new List<Product>()
       {
           new Product { Id = 1, Name = "TV", Price = 20000 },
           new Product { Id = 2, Name = "Speaker", Price = 5000},
           new Product { Id = 3, Name = "SmartPhone", Price = 15000},
           new Product { Id = 4, Name = "AC", Price = 30000},
           new Product { Id = 5, Name = "Iphone", Price = 45000},
           new Product { Id = 6, Name = "Laptop", Price = 50000}
       };

        var priceByDescending = products.OrderByDescending(p => p.Price).ToList();

        foreach (var product in priceByDescending)
        { 
            Console.WriteLine($"ProductID: {product.Id}, Product Name: {product.Name}, ProductPrice: {product.Price}");
        }
    }
}