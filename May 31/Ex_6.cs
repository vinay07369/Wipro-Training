using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
    class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; set; }
        public int BorrowedByStudentId { get; set; }
        public DateTime DueDate { get; set; }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Library
    {
        public List<Book> Books { get; set; } = new();
        public List<Student> Students { get; set; } = new();

        public void AddBook(Book book) => Books.Add(book);

        public void DeleteBook(int bookId)
        {
            var book = Books.FirstOrDefault(b => b.Id == bookId);
            if (book != null && !book.IsBorrowed)
                Books.Remove(book);
        }

        public bool BorrowBook(int bookId, int studentId, DateTime dueDate)
        {
            var book = Books.FirstOrDefault(b => b.Id == bookId && !b.IsBorrowed);
            var student = Students.FirstOrDefault(s => s.Id == studentId);
            if (book != null && student != null)
            {
                book.IsBorrowed = true;
                book.BorrowedByStudentId = studentId;
                book.DueDate = dueDate;
                return true;
            }
            return false;
        }

        public void ReturnBook(int bookId)
        {
            var book = Books.FirstOrDefault(b => b.Id == bookId && b.IsBorrowed);
            if (book != null)
            {
                book.IsBorrowed = false;
                book.BorrowedByStudentId = 0;
                book.DueDate = DateTime.MinValue;
            }
        }
        public void DisplayBooks()
        {
            foreach (var book in Books)
            {
                string status = book.IsBorrowed
                    ? $"Borrowed by Student ID {book.BorrowedByStudentId}, Due: {book.DueDate:yyyy-MM-dd}"
                    : "Available";
                Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, Status: {status}");
            }
        }
    }

    class LibraryProgram
    {
        static void Main(string[] args)
        {
            var library = new Library();

            // Sample students
            library.Students.Add(new Student { Id = 1, Name = "Vinay Kumar G" });
            library.Students.Add(new Student { Id = 2, Name = "Sai Seshu D" });

            // Sample books
            library.AddBook(new Book { Id = 1, Title = "C# in Depth", Author = "Jon Skeet" });
            library.AddBook(new Book { Id = 2, Title = "Clean Code", Author = "Robert C. Martin" });
            library.AddBook(new Book { Id = 3, Title = "The Pragmatic Programmer", Author = "Andrew Hunt and David Thomas" });

            // Main loop (simple demo)
            while (true)
            {
                Console.WriteLine("\nLibrary Menu:\n1. Display Books\n2. Add Book\n3. Delete Book\n4. Borrow Book\n5. Return Book\n6. Exit");

                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        library.DisplayBooks();
                        break;

                    case "2":
                        Console.Write("Enter Book Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();
                        int newId = library.Books.Any() ? library.Books.Max(b => b.Id) + 1 : 1;
                        library.AddBook(new Book { Id = newId, Title = title, Author = author });
                        Console.WriteLine("Book added.");
                        break;

                    case "3":
                        Console.Write("Enter Book ID to delete: ");
                        if (int.TryParse(Console.ReadLine(), out int delId))
                        {
                            library.DeleteBook(delId);
                            Console.WriteLine("Book deleted if it was available.");
                        }
                        break;
                    case "4":
                        Console.Write("Enter Book ID to borrow: ");
                        int.TryParse(Console.ReadLine(), out int borrowId);
                        Console.Write("Enter Student ID: ");
                        int.TryParse(Console.ReadLine(), out int studentId);
                        Console.Write("Enter due date (yyyy-MM-dd): ");
                        DateTime.TryParse(Console.ReadLine(), out DateTime dueDate);
                        if (library.BorrowBook(borrowId, studentId, dueDate))
                            Console.WriteLine("Book borrowed.");
                        else
                            Console.WriteLine("Borrow failed. Book may not be available or student not found.");
                        break;

                    case "5":
                        Console.Write("Enter Book ID to return: ");
                        int.TryParse(Console.ReadLine(), out int returnId);
                        library.ReturnBook(returnId);
                        Console.WriteLine("Book returned if it was borrowed.");
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}