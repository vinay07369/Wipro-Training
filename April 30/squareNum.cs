using System;

public class HelloWorld
{
    
    static int square(int n)
    {
        return n*n;
    }
    public static void Main(string[] args)
    {
        
        int result = square(5);
        
        Console.WriteLine("The square is:"+result);
        
    }
}
