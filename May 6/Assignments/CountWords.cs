using System;

public class Words
{
    static int count(string s)
    {
        int count = 0;

        string[] a = s.Split(' ');

        for(int i=0;i<a.Length;i++)
        {
            count++;
        }

        return count;

    }
    public static void Main(string[] args)
    {
        string s = "Learning c# is Fun";
        
        Console.WriteLine("Total words:"+ count(s));
    }
}