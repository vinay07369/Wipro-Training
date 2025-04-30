using System;

public class HelloWorld
{
    static int FindMax(int[] a)
    {
        int max = a[0];
        for(int i=1;i<a.Length;i++)
        {
            if(a[i]>max)
                max=a[i];
        }
        return max;
    }
    public static void Main(string[] args)
    {
        int[] a = {45,67,89,23,90};
        Console.WriteLine("Maximum number is:"+FindMax(a));
    }
}