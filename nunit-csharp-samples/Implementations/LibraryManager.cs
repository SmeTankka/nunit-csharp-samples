using System;
using System.Collections.Generic;
using System.Linq;

public class LibraryManager : ILibraryManager
{
    private List<Book> _books;

    public LibraryManager()
    {
        _books = new List<Book>();
    }

    public List<Book> Books => _books;

    public void AddBook(Book book)
    {
        if (book != null && !_books.Any(b => b.Articul == book.Articul))
        {
            _books.Add(book);
        }
        else
        {
            throw new Exception("Book cannot be added. It might already exist or null was provided.");
        }
    }

    public void RemoveBook(Book book)
    {
        _books.RemoveAll(b => b.Title == book.Title && b.Author == book.Author);
    }

    public List<Book> SearchBooks(string query)
    {
        return _books.Where(b => b.Title.Contains(query) || b.Author.Contains(query)).ToList();
    }
}
