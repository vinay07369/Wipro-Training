using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Appliance
    {
        public virtual void Operate()
        {
            Console.WriteLine("Appliance is ready...");  
        }
    }

    class WashingMachine : Appliance
    {
        public override void Operate()
        {
            Console.WriteLine("Washing Clothes...");
        }
    }

    class Program
    {
        static void Main()
        { 
            Appliance ap = new Appliance();

            Console.WriteLine("Using Appliance reference");
            Console.WriteLine("----------------------------");

            ap.Operate();
            Console.WriteLine();

            WashingMachine m = new WashingMachine();

            Console.WriteLine("Using Washingmachine reference");
            Console.WriteLine("----------------------------");

            m.Operate();
            Console.WriteLine();

            Appliance appliance = new WashingMachine();
            Console.WriteLine("Using Appliance reference by creating an object for Washingmachine");
            Console.WriteLine("----------------------------------------------------------------------");

            appliance.Operate();
        }
    }
}