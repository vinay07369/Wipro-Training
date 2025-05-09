using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showroom
{
    internal class Vehicle
    {

        public string Make;
        public string Model;

        public void DisplayVehicle()
        {
            Console.WriteLine($"Make : {Make}");
            Console.WriteLine($"Model : {Model}");
        }
    }

    class Car : Vehicle
    {
        public string FuelType;

        public void DisplayCar()
        {
            Console.WriteLine($"FuelType : {FuelType}");
        }      
    }
}