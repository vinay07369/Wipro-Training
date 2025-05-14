using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class FoodOrder
    {
        public abstract void PlaceOrder(string item);

        public void OrderInfo() => Console.WriteLine("Placing Food Order");

    }

    class FastFoodOrder : FoodOrder
    {
        public override void PlaceOrder(string item)
        {
            Console.WriteLine($"Order Placed for {item} at Fast Food Outlet ");
        }
    }

    class FineDiningOrder : FoodOrder
    {
        public override void PlaceOrder(string item)
        {
            Console.WriteLine($"Order Placed for {item} at Fine Dining Restaurant ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FoodOrder foodOrder;

            foodOrder = new FastFoodOrder();
            foodOrder.OrderInfo();
            foodOrder.PlaceOrder("Noodles");

            foodOrder = new FineDiningOrder();
            foodOrder.OrderInfo();
            foodOrder.PlaceOrder("Egg rice");
        }
    }
    
}
