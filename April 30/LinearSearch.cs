using System;

public class LinearSearch
{
    static string LinearSearch(int[] arr, int key)
    {
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]==key)
                return $"{i}";
        }
        return "Not Found";
    }
    public static void Main(string[] args)
    {
        int[] a = {3,5,7,8,2,9,10};
        Console.Write("Enter the key element:");
        int n = int.Parse(Console.ReadLine());
        
        string res = LinearSearch(a,n);
        Console.WriteLine($"The Index is: {res}");
    }
}