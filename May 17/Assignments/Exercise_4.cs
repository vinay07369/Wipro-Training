using System;

abstract class Animal
{
    public abstract void MakeSound();

    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    } 
}
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Barks");
    }
}
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meows");
    }
}
class Program
{
    static void Main()
    {
        Animal animal;

        animal = new Dog();
        animal.Eat();
        animal.MakeSound();

        animal = new Cat();
        animal.Eat();
        animal.MakeSound();

    }
}