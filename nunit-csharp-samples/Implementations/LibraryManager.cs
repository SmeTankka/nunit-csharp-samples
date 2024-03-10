using System.Collections.Generic;
using System.Linq; 

public class LibraryManager : ILibraryManager
{
    private List<Book> _books;

    public LibraryManager()
    {
        _books = new List<Book>(); 
    }

    /// <summary>
    /// Adds a book to the library's collection.
    /// </summary>
    /// <param name="book">The book to add.</param>
    public void AddBook(Book book)
{
    // Перевірка, чи передана книга не null і чи її артикул унікальний
    if (book != null && !_books.Any(b => b.Articul == book.Articul))
    {
        _books.Add(book); // Додавання книги до колекції, якщо вона унікальна
    }
    else
    {
        // Книга вже існує або передано null, тому викидаємо виняток
        throw new Exception("Book cannot be added. It might already exist or null was provided.");
    }
}


    /// <summary>
    /// Removes a book from the library's collection.
    /// </summary>
    /// <param name="book">The book to remove.</param>
    public void RemoveBook(Book book)
    {
        // Видалення книги з колекції за умовою відповідності назви та автора
        _books.RemoveAll(b => b.Title == book.Title && b.Author == book.Author);
    }

    public List<Book> SearchBooks(string query)
{
    return _books.Where(b => b.Title.Contains(query) || b.Author.Contains(query)).ToList();
}

}

