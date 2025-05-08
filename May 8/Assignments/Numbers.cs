using System;
using System.Collections;

namespace arrayList
{
    class Program
    {
        static void Main()
        {
            List<int> num = new  List<int> { 18, 7, 23, 12, 32, 16, 21, 4, 2, 9 };

            //sort the list in ascending order
            num.Sort();

            Console.WriteLine("Numbers after sorted:");

            foreach (int i in num)
            { 
                Console.Write(i+" ");
            }

            Console.WriteLine();
            
            // Maximum and Minimum Value
            int max = num[num.Count - 1];
            int min = num[0];

            Console.WriteLine($"Maximum:{max}");
            Console.WriteLine($"Manimum:{min}");

            //Average value
            double average = num.Average();

            Console.WriteLine("The Average:"+average);
        }
    }
}