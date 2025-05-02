using System;

public class Bubble
{
    //Bubble sort method
    public static void BubbleSort(int[] arr)
    {
        for(int i=0;i<arr.Length-1;i++)
        {
             for(int j=0;j<arr.Length-1;j++)
             {
                 if(arr[j]>arr[j+1])
                 {
                     int temp = arr[j];
                     arr[j]=arr[j+1];
                     arr[j+1]=temp;
                 }
             }
        }
    }
    //print the array
    public static void Printarray(int[] arr)
    {
        for(int i=0;i<arr.Length;i++)
        {
            Console.Write(arr[i]+" ");
        }
        Console.WriteLine();
    }
    //Main method
    public static void Main(string[] args)
    {
        int[] numbers = {64, 25, 12, 22, 11};
    
        Console.WriteLine("The original array");
        Printarray(numbers);
        
        BubbleSort(numbers);
        
        Console.WriteLine("The sorted array");
        Printarray(numbers);
        
       
    }
}