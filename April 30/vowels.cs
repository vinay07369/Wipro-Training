using System;

public class HelloWorld
{
    static int countVowels(string input)
    {
       int count=0;
       string vowels = "aeiouAEIOU";
       
       foreach (char c in input)
       {
           if(vowels.Contains(c))
                 count++;
       }
       return count;
    }
    public static void Main(string[] args)
    {
        string input = "Programming is fun";
        Console.WriteLine("Number of vowels:"+countVowels(input));
    }
}