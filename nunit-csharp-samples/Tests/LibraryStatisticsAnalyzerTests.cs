using NUnit.Framework;

namespace nunit_csharp_samples.Tests
{
    [TestFixture]
    public class LibraryStatisticsAnalyzerTests
    {
        private LibraryManager _manager;
        private LibraryStatisticsAnalyzer _analyzer;

        [SetUp]
        public void Setup()
        {
            _manager = new LibraryManager();
            _analyzer = new LibraryStatisticsAnalyzer(_manager);
            // Додайте кілька книг для тестування
            _manager.AddBook(new Book { Articul = "123", Title = "Test Book", Author = "Test Author" });
            _manager.AddBook(new Book { Articul = "124", Title = "Another Test Book", Author = "Another Author" });
        }

        [Test]
        public void GetBooksByAuthor_AuthorExists_ReturnsBooks()
        {
            var results = _analyzer.GetBooksByAuthor("Test Author");
            Assert.AreEqual(1, results.Count);
        }

        [Test]
        public void GetBookByTitle_TitleExists_ReturnsBook()
        {
            var result = _analyzer.GetBookByTitle("Test Book");
            Assert.IsNotNull(result);
            Assert.AreEqual("Test Book", result.Title);
        }

        [Test]
        public void GetBookByArticul_ArticulExists_ReturnsBook()
        {
            var result = _analyzer.GetBookByArticul("123");
            Assert.IsNotNull(result);
            Assert.AreEqual("123", result.Articul);
        }
    }
}
