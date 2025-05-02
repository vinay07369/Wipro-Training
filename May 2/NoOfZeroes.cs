using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int count = CountZeros(num);
        Console.WriteLine($"Number of zeros: {count}");
    }

    public static int CountZeros(int n)
    {
        if (n == 0)
            return 1; 

        return NoOfZeroes(n);
    }

    private static int NoOfZeroes(int n)
    {
        if (n == 0)
            return 0;

        int lastDigit = n % 10;
        int count = (lastDigit == 0) ? 1 : 0;

        return count + NoOfZeroes(n / 10);
    }
}