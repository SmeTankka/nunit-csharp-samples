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
        // Перевірка на відсутність книги в колекції перед додаванням
        if (!_books.Any(b => b.Title == book.Title && b.Author == book.Author))
        {
            _books.Add(book); // Додавання книги до колекції
        }
        else
        {
            // Книга вже існує, тому викидаємо виняток
            throw new Exception("Book already exists in the library.");
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

