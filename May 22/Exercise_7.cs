using System;

class Program
{
    static void Main()
    {
        List<int> number = new List<int>() { 2, 3, 5, 4, 7 ,6 ,10, 14, 23, 20};

        var evenNumbers = number.Where(num => num % 2 == 0);

        var oddNumbers = number.Where(num => num % 2 != 0);

        Console.WriteLine("Even Numbers List:");
        foreach (var n in evenNumbers)
        { 
            Console.Write(n +" ");
        }
        Console.WriteLine();
        Console.WriteLine("\nOdd Numbers List:");
        
        foreach (var n in oddNumbers)
        {
            Console.Write(n + " ");
        }
    }
}