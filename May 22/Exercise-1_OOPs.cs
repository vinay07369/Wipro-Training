using System;

abstract class Vehicle
{
    public string VehicleNumber { get; set; }
    public string Brand { get; set; }
    public double RatePerDay { get; set; }
    public virtual double CalculateRent(int days)
    { 
        return RatePerDay * days;
    }
}
class Car : Vehicle
{
    public override double CalculateRent(int days)
    {
        double baseRent =  base.CalculateRent(days);

        double surcharge = 0.1 * baseRent; //10% surcharge for Car

        return baseRent + surcharge;
    }
}
class Bike : Vehicle
{
    public override double CalculateRent(int days)
    {
        double baseRent = base.CalculateRent(days);

        double surcharge = 0.15 * baseRent; //15% surcharge for Bike

        return baseRent + surcharge;
    }
}
class Truck : Vehicle
{
    public override double CalculateRent(int days)
    {
        double baseRent = base.CalculateRent(days);

        double surcharge = 0.2 * baseRent; //20% surcharge for Truck

        return baseRent + surcharge;
    }

}
class Program
{
    static void Main()
    { 
        List<Vehicle> vehicles = new List<Vehicle>();

        //Creating Car Object
        Car car = new Car();
        car.VehicleNumber = "TN 20 VK 0856";
        car.Brand = "Mahindra XUV";
        car.RatePerDay = 100;

        //Creating Bike Object
        Bike bike = new Bike();
        bike.VehicleNumber = "TN 20 FG 7654";
        bike.Brand = "KTM Duke 200";
        bike.RatePerDay = 50;

        //Creating Truck Object
        Truck truck = new Truck();
        truck.VehicleNumber = "AP 37 UG 3542";
        truck.Brand = "Volvo";
        truck.RatePerDay = 120;

        //Adding all these Objects into the list
        vehicles.Add(car);
        vehicles.Add(bike);
        vehicles.Add(truck);

        Console.Write("Enter the Rental Days:");
        int rentalDays = Convert.ToInt32(Console.ReadLine());

        foreach (Vehicle vehicle in vehicles)
        { 
            double rent = vehicle.CalculateRent(rentalDays);

            Console.WriteLine($"{vehicle.GetType().Name} ({vehicle.Brand})");
            Console.WriteLine($"Rent for {rentalDays} Days: {rent}");
        }
    }
}