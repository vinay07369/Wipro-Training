using System;
using System.Collections.Generic;

namespace Assignment
{
    interface IRentable
    {
        void Rent(int days);
    }

    public class Vehicle : IRentable
    {
        public string Brand { get; set; }
        public double RentPerDay { get; set; }

        public virtual void Rent(int days)
        {
            Console.WriteLine($"Vehicle rented for {days} days. Total cost: {RentPerDay * days}");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Rent per day: {RentPerDay}");
        }
    }

    public class Car : Vehicle
    {
        public int NumberOfSeats { get; set; }

        public override void Rent(int days)
        {
            double cost = RentPerDay * days;

            Console.WriteLine($"Car rented for {days} days with {NumberOfSeats} seats. Total cost: {cost}");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Car => Brand: {Brand}, Seats: {NumberOfSeats}, Rent per day: {RentPerDay}");
        }
    }

    public class Bike : Vehicle
    {
        public bool HasCarrier { get; set; }

        public override void Rent(int days)
        {
            double cost = RentPerDay * days;

            Console.WriteLine($"Bike rented for {days} days. Carrier: {HasCarrier}. Total cost: {cost}");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Bike => Brand: {Brand}, Carrier: {HasCarrier}, Rent per day: {RentPerDay}");
        }
    }

    public class Truck : Vehicle
    {
        public double LoadCapacity { get; set; }

        public override void Rent(int days)
        {
            double cost = RentPerDay * days;

            Console.WriteLine($"Truck rented for {days} days with load capacity of {LoadCapacity} tons. Total cost: {cost}");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Truck => Brand: {Brand}, Load Capacity: {LoadCapacity} tons, Rent per day: {RentPerDay}");
        }
    }

    class Program
    {
        static void Main()
        {
            List<IRentable> vehicles = new List<IRentable>
            {
                new Car { Brand = "Toyota", RentPerDay = 50, NumberOfSeats = 5 },
                new Bike { Brand = "Yamaha", RentPerDay = 15, HasCarrier = true },
                new Truck { Brand = "Volvo", RentPerDay = 120, LoadCapacity = 10 }
            };

            Console.WriteLine("Available Vehicles:");
            Console.WriteLine("-------------------");

            foreach (Vehicle v in vehicles)
            {
                v.DisplayInfo();
            }

            Console.WriteLine("\nRenting all vehicles for 3 days:");
            Console.WriteLine("--------------------------------------");

            foreach (IRentable rentable in vehicles)
            {
                rentable.Rent(10);
            }
        }
    }
}