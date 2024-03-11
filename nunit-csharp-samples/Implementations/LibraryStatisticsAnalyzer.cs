using System.Collections.Generic;
using System.Linq;

public class LibraryStatisticsAnalyzer
{
    private readonly LibraryManager _manager;

    public LibraryStatisticsAnalyzer(LibraryManager manager)
    {
        _manager = manager;
    }
    
    /// <summary>
    /// Gets books by author.
    /// </summary>
    /// <param name="author">Book author.</param>
    /// <returns>List of books by the specified author.</returns>
    public List<Book> GetBooksByAuthor(string author)
    {
        return _manager.Books.Where(b => b.Author == author).ToList();
    }
    
    /// <summary>
    /// Gets book by title.
    /// </summary>
    /// <param name="title">Book title.</param>
    /// <returns>Book with the specified title or null if not found.</returns>
    public Book GetBookByTitle(string title)
    {
        return _manager.Books.FirstOrDefault(b => b.Title == title);
    }

    /// <summary>
    /// Gets book by articul.
    /// </summary>
    /// <param name="articul">Book articul.</param>
    /// <returns>Book with the specified articul or null if not found.</returns>
    public Book GetBookByArticul(string articul)
    {
        return _manager.Books.FirstOrDefault(b => b.Articul == articul);
    }
}
