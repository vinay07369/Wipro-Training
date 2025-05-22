using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}
class CartItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public double GetTotalPrice()
    {
        return Product.Price * Quantity;
    }
}
class ShoppingCart
{
    private List<CartItem> cartItems = new List<CartItem>();

    public void AddItem(Product product, int quantity)
    {
        var existingItem = cartItems.FirstOrDefault(ci => ci.Product.Id == product.Id);

        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            cartItems.Add(new CartItem { Product = product, Quantity = quantity });
        }
    }
    public void RemoveItem(int productId)
    {
        var item = cartItems.FirstOrDefault(ci => ci.Product.Id == productId);

        if (item != null)
        {
            cartItems.Remove(item);
        }
    }
    public double GetCartTotal()
    {
        return cartItems.Sum(item => item.GetTotalPrice());
    }
}

class Program
{
    static void Main()
    {
        var product1 = new Product { Id = 1, Name = "Laptop", Price = 1200.00 };
        var product2 = new Product { Id = 2, Name = "Mouse", Price = 100.50 };
        var product3 = new Product { Id = 3, Name = "Keyboard", Price = 45.00 };

        var cart = new ShoppingCart();

        cart.AddItem(product1, 1);
        cart.AddItem(product2, 2);
        cart.AddItem(product3, 1);

        Console.WriteLine($"Total cart value: {cart.GetCartTotal()}");
    }
}