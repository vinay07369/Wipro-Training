using System;

public class HelloWorld
{
    
    static int add(int a, int b)
    {
        return a+b;
    }
    
    static double add(double a, double b)
    {
        return a+b;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Int add:"+add(5,7));
        Console.WriteLine("Double add:"+add(5.8,6.7));
    }
}
