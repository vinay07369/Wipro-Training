using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    { 
     
        List<string> fruits = new List<string>() { "Apple", "Banana", "Cherry"};

        //Adding the element
        fruits.Add("Mango");

        //Insert the element at index 1
        fruits.Insert(1, "Orange");

        //Remove the element by value
        fruits.Remove("Banana");

        //Remove the element by index
        fruits.RemoveAt(2);

        //Checking if an element exists or not
        if (fruits.Contains("Apple"))
        {
            Console.WriteLine("Apple is in the list");
        }

        //sort the list
        fruits.Sort();

        //Print the final list
        Console.WriteLine("Fruits lists:");

        foreach (string fruit in fruits) { 
            Console.WriteLine(fruit);
        }
    }
}
    
