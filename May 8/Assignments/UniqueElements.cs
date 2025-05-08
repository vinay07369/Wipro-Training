using System;
using System.Collections;

namespace Numbers
{
    class uniqueElements
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 1, 2, 4, 2, 1, 5, 2, 6, 5, 1 };

            HashSet<int> unique = new HashSet<int>(numbers);

            // Find and print the unique elements
            Console.WriteLine("Unique Elements:");

            foreach (int i in unique)
            { 
                Console.WriteLine(i+" ");
            }
            
            // number of unique elements
            Console.WriteLine("The number of unique elements:"+unique.Count);
         
        }
    }
}