using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppM26
{
    internal class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>
            {
                new Item { Name = "Laptop", Type = "Electronics", Stock = 10, Price = 800.00 },
                new Item { Name = "Smartphone", Type = "Electronics", Stock = 20, Price = 500.00 },
                new Item { Name = "Tablet", Type = "Electronics", Stock = 15, Price = 300.00 },
                new Item { Name = "Headphones", Type = "Accessories", Stock = 50, Price = 100.00 },
                new Item { Name = "Charger", Type = "Accessories", Stock = 30, Price = 20.00 },
                new Item { Name = "Mouse", Type = "Accessories", Stock = 25, Price = 25.00 },
                new Item { Name = "Keyboard", Type = "Accessories", Stock = 40, Price = 30.00 },
                new Item { Name = "Monitor", Type = "Electronics", Stock = 5, Price = 200.00 },
                new Item { Name = "Printer", Type = "Electronics", Stock = 8, Price = 150.00 },
                new Item { Name = "Webcam", Type = "Accessories", Stock = 12, Price = 60.00 },
                new Item { Name = "Speakers", Type = "Accessories", Stock = 18, Price = 80.00 },
                new Item { Name = "External Hard Drive", Type = "Storage", Stock = 7, Price = 120.00 },
                new Item { Name = "USB Flash Drive", Type = "Storage", Stock = 22, Price = 15.00 },
                new Item { Name = "Router", Type = "Networking", Stock = 10, Price = 90.00 },
                new Item { Name = "Modem", Type = "Networking", Stock = 6, Price = 70.00 }
            };
            var lowStockItems = items.Where(i => i.Stock < 10);

            Console.WriteLine("Items with low stock (less than 10):");
            Console.WriteLine("-------------------------------------------------");

            foreach (var item in lowStockItems)
            {
                Console.WriteLine($"{item.Name} - {item.Type} - {item.Stock} in stock - ${item.Price}");
            }

            Console.WriteLine("\nTotal number of items in low stock: " + lowStockItems.Count());

            var highestPricedItem = items
                                         .GroupBy(i => i.Type)
                                         .Select(g => g.OrderByDescending(i => i.Price).FirstOrDefault());

            Console.WriteLine("\nHighest priced item in each category:");
            Console.WriteLine("-------------------------------------------------");

            foreach (var item in highestPricedItem)
            {
                Console.WriteLine($"{item.Name} - {item.Type} - ${item.Price}");
            }
        }
    }
}
