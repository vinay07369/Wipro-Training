using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppM26
{
    class Program
    { 
        static void Main(string[] args)
        {
            string paragraph = "The sun was shining, the sun was bright. The children played under the sun while the birds sang in the trees. It was a beautiful day, a truly beautiful day to be outside.";

            string[] words = paragraph.ToLower().Split(new[] {' '});

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
                else
                {
                    wordCount[word] = 1;
                }
            }

            var topWords = wordCount.OrderByDescending(w => w.Value)
                                .Take(5)
                                .Select(w => new { Word = w.Key, Count = w.Value });

            Console.WriteLine("Top 5 Frequent Words:\n");

            foreach (var item in topWords)
            {
                Console.WriteLine($"{item.Word} - {item.Count} times");
            }
        }
    }
}

