using System;

public class largestOfThree
{
    public static void Main(string[] args)
    {
       Console.Write("Enter the value of a:");
       int a=int.Parse(Console.ReadLine());
       
       Console.Write("Enter the value of b:");
       int b=int.Parse(Console.ReadLine());
       
       Console.Write("Enter the value of c:");
       int c=int.Parse(Console.ReadLine());
       
       if(a>b & a>c)
           Console.WriteLine($"{a} is Largest Number");
       else if(b>a & b>c)
           Console.WriteLine($"{b} is Largest Number");
       else
           Console.WriteLine($"{c} is Largest Number");
    }
}