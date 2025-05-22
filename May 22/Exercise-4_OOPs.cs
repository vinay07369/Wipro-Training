using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Book
{ 
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; }

    public override string ToString()
    {
        return $"{Id}: {Title} by {Author} - {(IsAvailable ? "Available" : "Checked Out")}";
    }
}

class Library
{ 
    List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void SearchByAuthor(string author)
    {
        var foundBooks = books.Where(b => b.Author.Equals(author)).ToList();

        if (foundBooks.Count > 0)
        {
            Console.WriteLine($"Books by {author}:");
            foreach (var book in foundBooks)
            {
                Console.WriteLine(book);
            }
        }
        else
        {
            Console.WriteLine($"No books found by {author}.");
        }
    }

    public void SearchByTitle(string title)
    {
        var foundBooks = books.Where(b => b.Title.Equals(title)).ToList();

        if (foundBooks.Count > 0)
        {
            Console.WriteLine($"Books with title '{title}':");
            foreach (var book in foundBooks)
            {
                Console.WriteLine(book);
            }
        }
        else
        {
            Console.WriteLine($"No books found with title '{title}'.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        // Adding some books to the library
        library.AddBook(new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", IsAvailable = true });
        library.AddBook(new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", IsAvailable = false });
        library.AddBook(new Book { Id = 3, Title = "1984", Author = "George Orwell", IsAvailable = true });

        // Searching for books by author
        library.SearchByAuthor("George Orwell");

        // Searching for books by title
        library.SearchByTitle("The Great Gatsby");
    }
}