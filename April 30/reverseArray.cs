using System;

public class HelloWorld
{
    static void Reversearray(int[] arr)
    {
        for(int i=arr.Length-1;i>=0;i--)
        {
            Console.WriteLine($"The Reversed element are: {arr[i]}");
        }
    }
    public static void Main(string[] args)
    {
        int[] a = {10,20,30,40,50};
        Reversearray(a);
    }
}
