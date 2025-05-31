using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
    public interface IPrintable
    {
        void Print();
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Subtotal => Price * Quantity;
    }

    public abstract class Invoice : IPrintable
    {
        public List<Product> Products { get; set; } = new();
        public double TaxRate { get; set; }
        public double Discount { get; set; } 

        public abstract double CalculateTotal();

        public virtual void Print()
        {
            Console.WriteLine("Invoice Details:");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Product\t\tPrice\tQty\tSubtotal");
            foreach (var p in Products)
            {
                Console.WriteLine($"{p.Name}\t{p.Price}\t{p.Quantity}\t{p.Subtotal}");
            }     

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Tax Rate: {TaxRate * 100}%");
            Console.WriteLine($"Discount: {Discount}");
            Console.WriteLine($"Total: {CalculateTotal()}");
            Console.WriteLine();
        }
    }

    public class RetailInvoice : Invoice
    {
        public override double CalculateTotal()
        {
            double subtotal = Products.Sum(p => p.Subtotal);
            double tax = subtotal * TaxRate;
            return subtotal + tax - Discount;
        }
    }

    public class WholesaleInvoice : Invoice
    {
        public override double CalculateTotal()
        {
            double subtotal = Products.Sum(p => p.Subtotal);
            double tax = subtotal * TaxRate;

            // Wholesale: discount is applied before tax
            return (subtotal - Discount) + ((subtotal - Discount) * TaxRate);
        }
    }

    class InvoiceProgram
    {
        static void Main(string[] args)
        {
            var retailInvoice = new RetailInvoice
            {
                TaxRate = 0.10, // 10%
                Discount = 20
            };

            retailInvoice.Products.Add(new Product { Name = "Pen", Price = 5, Quantity = 10 });
            retailInvoice.Products.Add(new Product { Name = "Notebook", Price = 20, Quantity = 2 });

            var wholesaleInvoice = new WholesaleInvoice
            {
                TaxRate = 0.08, // 8%
                Discount = 50
            };

            wholesaleInvoice.Products.Add(new Product { Name = "Box of Markers", Price = 100, Quantity = 1 });
            wholesaleInvoice.Products.Add(new Product { Name = "Paper Ream", Price = 200, Quantity = 3 });

            Console.WriteLine("Retail Invoice:");
            retailInvoice.Print();

            Console.WriteLine("Wholesale Invoice:");
            wholesaleInvoice.Print();
        }
    }
}