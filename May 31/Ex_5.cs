using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Assignment
{
    class StringAnalyzer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a paragraph:");
            string input = Console.ReadLine();

            // create a dictionary to store word frequency
            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            // split the words in the input string
            string[] words = input.Split(' ');

            //1. count word frequency
            var wordFrequency = words.GroupBy(word => word.ToLower())
                                     .ToDictionary(group => group.Key, group => group.Count());

            Console.WriteLine("\nWord Count:");
            Console.WriteLine("-------------");

            foreach (var word in wordFrequency)
            {
                Console.WriteLine($"{word.Key}: {word.Value}");
            }

            //2. Count vowels and consonants
            int vowelCount = 0;
            int consonantCount = 0;

            string vowels = "aeiouAEIOU";
            foreach (char c in input)
            {
                if (vowels.Contains(c))
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
            }

            Console.WriteLine("\nVowels and Consonants count:");
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Vowel Count: {vowelCount}");
            Console.WriteLine($"Consonant Count: {consonantCount}");

            //3. find the longest word and shortest word
            Console.WriteLine("\nLongest and Shortest Words:");
            Console.WriteLine("-----------------------------");

            string longestWord = words.OrderByDescending(word => word.Length).FirstOrDefault();
            Console.WriteLine($"Longest Word: {longestWord}");

            string shortestWord = words.OrderBy(word => word.Length).FirstOrDefault();
            Console.WriteLine($"Shortest Word: {shortestWord}");
        }
    }
}