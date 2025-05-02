using System;

public class Program
{
    public static int LinearSearch(int[] arr, int target)
    {
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i]==target)
                return i;
        }
        return -1;
        
    }
    public static void Main(string[] args)
    {
        int[] numbers = {10,20,30,45,60,75};
        int target=45;
        
        int result=LinearSearch(numbers,target);
        
        if(result!=-1)
            Console.WriteLine($"Element {target} found at index {result}");
        else
            Console.WriteLine($"Element {target} not found");
    }
}