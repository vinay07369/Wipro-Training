using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        for (int i = 1; ; i++)
        {
            int square = i * i;
            if (square > 100)
            {
                break;
            }
            Console.WriteLine($"The square of {i} is {square}");
        }
    }
}