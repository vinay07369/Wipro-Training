using System;
using System.Collections;

namespace city
{
    class Program
    {
        static void Main()
        { 
           Dictionary<string,string> cities = new Dictionary<string, string>
           {
               {"Chennai", "Tamilnadu" },
               {"Hyderabad", "Telangana"},
               {"Mumbai", "Maharastra"},
               {"Kolkata", "WestBengal"},
               {"Bangalore", "Karnataka" }
           };

            Console.WriteLine("Indian cities and their States");

            foreach (var item in cities)
            {
                Console.WriteLine($"{item.Key} is in {item.Value}");
            }

            if (cities.ContainsKey("Chennai"))
            {
                Console.WriteLine("City exists");
            }
        }
    }
}


    