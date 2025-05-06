using System;

public class SecondLargest
{
    static void pattern()
    {
        int n = 4;
        for(int i = 0;i <= n;i++)
        {
            for(int j = 1;j <= i;j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
   
    public static void Main(string[] args)
    {
       pattern();
    }
}