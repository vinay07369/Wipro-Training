using System;

public class Palindrome
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the input:");
        string s = Console.ReadLine();
        
        string rev="";
        
        for(int i=s.Length-1;i>=0;i--)
        {
            rev+=s[i];
        }
        
        if(rev==s)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not a Palindrome");
    }
    
}