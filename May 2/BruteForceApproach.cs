using System;

public class BruteforceApproach
{
    static void FindpairSum(int[] arr, int target)
    {
        for(int i=0;i<arr.Length;i++)
        {
            for(int j=i+1;j<arr.Length;j++)
            {
                if(arr[i]+arr[j]==target)
                    Console.WriteLine($"{arr[i]} + {arr[j]} = {target}");
            }
        }
    }
    
    public static void Main(string[] args)
    {
        int[] a={2,5,7,4,6};
        int targetsum=9;
        
        FindpairSum(a, targetsum);
    }
}