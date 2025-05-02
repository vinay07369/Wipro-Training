using System;

public class Factorial
{
    static int factorial(int n)
    {
        if(n<=1)
            return 1;
        else
            return n*factorial(n-1);
    }
    public static void Main(string[] args)
    {
        Console.Write("Enter the number:");
        int n = int.Parse(Console.ReadLine());
        
        int result=factorial(n);
        
        Console.WriteLine($"The Factorial of {n} is {result}");
    }
}