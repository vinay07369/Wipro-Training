using System;

class Program
{
    static void Main()
    {
        string sentence = "C# is great and C# is fun"; // Input a sentence

        string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries); // split the words

        var wordFrequency = words.GroupBy(word => word)
                                 .Select(group => new { Word = group.Key , Count = group.Count()});  
        
        foreach ( var word in wordFrequency )
        {

            Console.WriteLine($"{word.Word} : {word.Count}");
        }
    }
}