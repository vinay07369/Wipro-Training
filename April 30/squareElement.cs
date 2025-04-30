using System;

public class HelloWorld
{
    static void squarearray(int[] arr)
    {
        for(int i=0;i<arr.Length;i++)
        {
            Console.WriteLine($"The Square element is: {arr[i]*arr[i]}");
        }
    }
    public static void Main(string[] args)
    {
        int[] a = {3,4,2,7,5};
        squarearray(a);
    }
}