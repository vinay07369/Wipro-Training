using System;

public class Fibonacci
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the number of terms: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Fibonacci Series:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(FibonacciRec(i) + " ");
        }
    }

    // Recursive method to return the nth Fibonacci number
    static int FibonacciRec(int n)
    {
        if (n <= 1)
            return n;
        return FibonacciRec(n - 1) + FibonacciRec(n - 2);
    }
}