using System.Collections.Generic;
using System.Linq;

public class LibraryStatisticsAnalyzer
{
    private readonly LibraryManager _manager;

    public LibraryStatisticsAnalyzer(LibraryManager manager)
    {
        _manager = manager;
    }

    public List<Book> GetBooksByAuthor(string author)
    {
        return _manager.Books.Where(b => b.Author == author).ToList();
    }

    public Book GetBookByTitle(string title)
    {
        return _manager.Books.FirstOrDefault(b => b.Title == title);
    }

    public Book GetBookByArticul(string articul)
    {
        return _manager.Books.FirstOrDefault(b => b.Articul == articul);
    }
}
