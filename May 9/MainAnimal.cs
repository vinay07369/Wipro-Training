using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inheritance;

namespace ConsoleApp2
{
    internal class MainAnimal
    {
        static void Main()
        { 
            //Creating an object for dog class
            Dog d = new Dog();  

            d.Name = "Buddy";
            d.Species = "Canine";
            d.Breed = "Labrodar";

            //Display animal details
            d.DisplayAnimal();

            //Display dog-specific details
            d.DisplayDog();
        }
    }
}
