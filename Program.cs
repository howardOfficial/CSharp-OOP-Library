using System;
using System.Collections.Generic;

namespace LibraryApp
{
    // Класс Книга
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        
        public override string ToString() => $"{Title} - {Author}";
    }

    // Класс Библиотека
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Книга '{book.Title}' добавлена.");
        }

        public void ShowAllBooks()
        {
            Console.WriteLine("\nСписок книг в библиотеке:");
            foreach (var book in books)
            {
                Console.WriteLine($"- {book}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Library myLibrary = new Library();
            
            myLibrary.AddBook(new Book("Война и мир", "Л. Толстой"));
            myLibrary.AddBook(new Book("Преступление и наказание", "Ф. Достоевский"));
            myLibrary.AddBook(new Book("Мастер и Маргарита", "М. Булгаков"));

            myLibrary.ShowAllBooks();
        }
    }
}
