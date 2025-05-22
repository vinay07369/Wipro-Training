using System;
using System.Collections.Generic;
using System.IO;

abstract class Animal
{ 
    public string Name { get; set; }
    public int Age { get; set; }
    public abstract void MakeSound();

    public void Feed()
    {
        Console.WriteLine("Feeding the Animal");
    }
}

class Lion : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Roar!");
    }
}

class Elephant : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Trumpet!");
    }
}

class Monkey : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Ooh Ooh Aah Aah!");
    }
}

class Zoo
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>
        {
            new Lion { Name = "Leo", Age = 5 },
            new Elephant { Name = "Dumbo", Age = 10 },
            new Monkey { Name = "George", Age = 3 }
        };
        foreach (var animal in animals)
        {
            Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}");
            animal.MakeSound();
            animal.Feed();
        }
    }
}