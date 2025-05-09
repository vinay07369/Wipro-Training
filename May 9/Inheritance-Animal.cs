using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Animal
    {
        public string Name;
        public string Species;

        //Display animal details
        public void DisplayAnimal()
        {
            Console.WriteLine($"Name:{Name}");
            Console.WriteLine($"Species: {Species}");
        }
    }

    class Dog : Animal 
    {
        public string Breed;

        //Display dog details
        public void DisplayDog()
        {
            Console.WriteLine($"Breed:{Breed}");
        }
    
    }
}
