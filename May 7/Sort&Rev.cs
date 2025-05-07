using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    { 
        ArrayList list = new ArrayList() { 4, 1, 8, 3};

        list.Sort();
        Console.WriteLine("Sorted:");

        foreach (int num in list)
        {
            Console.WriteLine(num); // output: {1, 3, 4, 8}

        }

        list.Reverse();
        Console.WriteLine("Reversed:");

        foreach (int num in list)
        {
            Console.WriteLine(num); //output: {8, 4, 3, 1}
        }
    }
}
    
