using System;

class Program
{
    static int sumOfDigits(int n)
    {
        if(n==0)
            return 0;
        else
            return (n%10)+sumOfDigits(n/10);
    }
    
    public static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int n=int.Parse(Console.ReadLine());
        
        int sum=sumOfDigits(n);
        
        Console.WriteLine($"The sum of digits of {n} is {sum}");
    }
}