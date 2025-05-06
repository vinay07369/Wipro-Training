using System;

public class SecondLargest
{
    static int secondLargest(int[] a)
    {
        int first = int.MinValue;
        int second = int.MinValue;
        
        foreach (int n in a)
        {
            if(n > first)
            {
                second = first;
                first = n;
            }else if(n > second && n != first)
            {
                second = n;
            }
        }
        return second;
    }
    public static void Main(string[] args)
    {
        int[] a = {10, 25, 30, 5, 60};
        
        int result = secondLargest(a);
        
        Console.WriteLine ("Second Largest Element:"+result);
    }
}