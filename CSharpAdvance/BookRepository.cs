using System.Collections.Generic;

namespace CSharpAdvance
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){Title = "book 1", Price = 5},
                new Book(){Title = "book 2", Price = 9},
                new Book(){Title = "book 3", Price = 12}

            };
        }
        
    }
}