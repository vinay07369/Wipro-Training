using System;

public class Words
{
    public static void Main(string[] args)
    {
        string s = "Learning c# is Fun";
        
        string[] a = s.Split(' ');
        
        Console.WriteLine("Total words:"+a.Length);
    }
}