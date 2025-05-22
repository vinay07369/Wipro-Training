using System;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main()
    { 
        List<Product> products = new List<Product>();

        products.Add(new Product { Name = "TV", Price = 150.0});
        products.Add(new Product { Name = "SmartPhone", Price = 1700.0 });
        products.Add(new Product { Name = "Laptop", Price = 1000.0 });
        products.Add(new Product { Name = "Speaker", Price = 600.0});
        products.Add(new Product { Name = "Iphone", Price = 5000.0});

        Console.WriteLine("Product Details:");
        Console.WriteLine("------------------");

        foreach (var product in products)
        { 
            Console.WriteLine($"Product Name:{product.Name}, Product Price:{product.Price}");
        }

        var linqProducts = products.Where(p => p.Price > 500);

        Console.WriteLine();

        Console.WriteLine("Products with price greater that 500:");
        Console.WriteLine("--------------------------------------");
        foreach (var product in linqProducts)
        {
            Console.WriteLine($"Product Name:{product.Name}, Product Price:{product.Price}");
        }
    }
}