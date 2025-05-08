using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    { 
        List<int> numbers = new List<int>();

        //Adding elements
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        //Printing elements
        foreach (int i in numbers)
        { 
            Console.WriteLine(i);
        }
    }
}
    
