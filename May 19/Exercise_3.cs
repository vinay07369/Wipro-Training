using System;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}");
    }
}

class Program

{
    static void Main()
    {
        Queue<Book> borrowed = new Queue<Book>(); // Queue
        borrowed.Enqueue(new Book { Title = "The Alchemist", Author = "Paulo Coelho" });
        borrowed.Enqueue(new Book { Title = "1984", Author = "George Orwell" });
        borrowed.Enqueue(new Book { Title = "To Kill a Mockingbird", Author = "Harper Lee" });
        borrowed.Enqueue(new Book { Title = "Sapiens", Author = "Yuval Noah Harari" });
        borrowed.Enqueue(new Book { Title = "The Hobbit", Author = "J.R.R. Tolkien" });

        Console.WriteLine("Next book to be returned:");
        borrowed.Peek().Display();

        Console.WriteLine("\nNext book removed...");
        borrowed.Dequeue();

        Stack<Book> purchased = new Stack<Book>(); //Stack
        purchased.Push(new Book { Title = "Clean Code", Author = "Robert C. Martin" });
        purchased.Push(new Book { Title = "The Pragmatic Programmer", Author = "Andrew Hunt" });
        purchased.Push(new Book { Title = "Design Patterns", Author = "Erich Gamma"});

        Console.WriteLine("\nLast Book Purchased:");
        purchased.Peek().Display();

        Console.WriteLine("\nRemoved last purchased book...");
        purchased.Pop();

        Console.WriteLine("\nRemaining Books Borrowed..");
        foreach (var item in borrowed)
        {
            item.Display();
        }

        Console.WriteLine("\nRemaining Books Purchased..");
        foreach (var item in purchased)
        {
            item.Display();
        }
    }
}