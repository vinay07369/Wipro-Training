using System;
using System.Collections;

namespace myApp 
{
    class program
    {
        static void Main()
        { 
            List<int> num = new List<int> { 10, 20, 30 ,40, 50};

            int index = num.IndexOf(40);
            Console.WriteLine("Index of 40:"+index);

            bool contains = num.Contains(40);
            Console.WriteLine("Contains 40:" + contains);
        }
    }
}