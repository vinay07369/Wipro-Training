using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showroom
{
    internal class MainVehicle
    {

        static void Main()
        { 
            Car c = new Car();

            c.Make = "Audi";
            c.Model = "A4";
            c.FuelType = "Diesal";

            c.DisplayVehicle();

            c.DisplayCar();
        }
    }
}
