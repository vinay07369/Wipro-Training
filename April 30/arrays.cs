using System;

public class HelloWorld
{
    static void Printarray(int[] arr)
    {
        for(int i=0;i<arr.Length;i++)
        {
            Console.WriteLine($"The element {i+1}: {arr[i]}");
        }
    }
    public static void Main(string[] args)
    {
        int[] a = {10,20,30,40,50};
        Printarray(a);
    }
}
