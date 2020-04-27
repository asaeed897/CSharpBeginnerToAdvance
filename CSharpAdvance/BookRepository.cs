using System.Collections.Generic;

namespace CSharpAdvance
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "book 1", Price = 5},
                new Book() {Title = "book 2", Price = 15},
                new Book() {Title = "book 3", Price = 20},
                new Book() {Title = "book 4", Price = 6},
                new Book() {Title = "book 5", Price = 12},
            };
        }
    }
}