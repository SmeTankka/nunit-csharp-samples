using NUnit.Framework;
using System.Linq;

namespace nunit_csharp_samples.Tests
{
    [TestFixture]
    public class LibraryManagerTests
    {
        private LibraryManager _manager;

        [SetUp]
        public void Setup()
        {
            _manager = new LibraryManager();
        }

        [Test]
        public void AddBook_BookIsNull_ThrowsException()
        {
            Assert.Throws<System.Exception>(() => _manager.AddBook(null));
        }

        [Test]
        public void AddBook_BookIsNotNull_AddsBook()
        {
            var book = new Book { Articul = "123", Title = "Test Book", Author = "Test Author" };
            _manager.AddBook(book);
            Assert.IsTrue(_manager.Books.Contains(book));
        }

        [Test]
        public void RemoveBook_BookExists_RemovesBook()
        {
            var book = new Book { Articul = "123", Title = "Test Book", Author = "Test Author" };
            _manager.AddBook(book);
            _manager.RemoveBook(book);
            Assert.IsFalse(_manager.Books.Contains(book));
        }

        [Test]
        public void SearchBooks_QueryMatches_ReturnsBooks()
        {
            var book = new Book { Articul = "123", Title = "Test Book", Author = "Test Author" };
            _manager.AddBook(book);
            var results = _manager.SearchBooks("Test");
            Assert.AreEqual(1, results.Count);
        }
    }
}
