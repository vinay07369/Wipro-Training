using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal interface IOrder
    {
        public void PlaceOrder(string item);

        public void CancelOrder(string itemm);
    }

    class DineInOrder : IOrder
    {
        public void PlaceOrder(string item)
        {
            Console.WriteLine($"Placing dine-In order for item : {item}");
        }

        public void CancelOrder(string item)
        {
            Console.WriteLine($"Canceling dine-In order for item : {item}");
        }
    }

    class TakeawayOrder : IOrder
    {
        public void PlaceOrder(string item)
        {
            Console.WriteLine($"Placing Takeaway order for item : {item}");
        }

        public void CancelOrder(string item)
        {
            Console.WriteLine($"Canceling Takeaway order for item : {item}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IOrder order;

            order = new DineInOrder();

            order.PlaceOrder("Pizza");
            order.CancelOrder("Biriyani");

            order = new TakeawayOrder();

            order.PlaceOrder("Biriyani");
            order.CancelOrder("White Rice");

        }
    }
}