using System;

public class Program
{
    public static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Array elements:");
        PrintArray(arr, 0); 
    }

    public static void PrintArray(int[] arr, int index)
    {
        if (index >= arr.Length)
            return;

        Console.Write(arr[index]+" ");

        PrintArray(arr, index + 1);
    }
}