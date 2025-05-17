using System;

interface IMaintenance
{
    public void Service();
    public void Repair();
}

class CarMaintenance : IMaintenance
{
    public void Service()
    {
        Console.WriteLine("Car is being serviced");
    }
    public void Repair()
    {
        Console.WriteLine("Car is being repaired");
    }
}

class BikeMaintenence : IMaintenance
{
    public void Service()
    {
        Console.WriteLine("Bike is being serviced");
    }
    public void Repair()
    {
        Console.WriteLine("Bike is being repaired");
    }
}

class Program
{
    static void Main()
    {
        IMaintenance maintenance;

        Console.WriteLine("Car Maintenance Details");
        maintenance = new CarMaintenance();
        maintenance.Service();
        maintenance.Repair();

        Console.WriteLine("---------------------");

        Console.WriteLine("Bike Maintenance Details");
        maintenance = new BikeMaintenence();
        maintenance.Service();
        maintenance.Repair();
    }
}