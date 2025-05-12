using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface IAnimalActions
    {
        void Eat();

        void Sleep();
    }

    class Lion : IAnimalActions
    {
        public void Eat()
        {
            Console.WriteLine("Lion is eating Meat");
        }

        public void Sleep()
        { 
            Console.WriteLine("Lion is sleeping");
        }
    }

    class Elephant : IAnimalActions
    {
        public void Eat()
        {
            Console.WriteLine("Elephant is eating grass");
        }

        public void Sleep()
        { 
            Console.WriteLine("Elephant is sleeping");
        }
    }

    class Program
    {
        static void Main()
        {
            IAnimalActions actions; 

            actions = new Lion(); // Creating object for Lion using IAnimalAction reference

            Console.WriteLine("Lion Object");
            Console.WriteLine("--------------");
            actions.Eat();
            actions.Sleep();

            actions = new Elephant();// Creating object for Elephant using IAnimalAction reference
            Console.WriteLine("Elephant Object");
            Console.WriteLine("--------------");

            actions.Eat();
            actions.Sleep();
        }
    }
}
