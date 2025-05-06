using System;

public class SumOfDigits
{
    static int sum(int n)
    {
        int sum = 0;
        
        while(n>0)
        {
            int lastDigit = n%10;
            sum = sum + lastDigit;
            n = n/10;
        }
        
        return sum;
    }
    public static void Main(string[] args)
    {
        int n = 1234;
        
        Console.WriteLine ("Sum Of Digits:"+sum(n));
    }
}