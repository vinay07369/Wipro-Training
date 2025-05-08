using System;
using System.Collections;

namespace books
{
    class Program
    {
        static void Main()
        {
            //Creating a stack of strings
            Stack<string> books = new Stack<string>();

            //pushing elements on to the stack
            books.Push("C# programming");
            books.Push("Data structures");
            books.Push("Machine Learning");

            Console.WriteLine("Books in the stack:");
            foreach (var book in books)
            { 
                Console.WriteLine(book);
            }

            //popping an element
            Console.WriteLine("\nPopped:"+books.Pop());

            //peeking at the top element
            Console.WriteLine("Next on the stack:"+books.Peek());
            
        }
    }
}
