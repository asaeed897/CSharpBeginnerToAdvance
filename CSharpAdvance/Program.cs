using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            /*var cheapBooks = new List<Book>();
            foreach (var book in books)
            {
                if (book.Price < 10)
                    cheapBooks.Add(book);

            }*/
            
            // LINQ Query Operations
            var cheapBooks1 = from b in books
                where b.Price < 10
                orderby b.Title
                select b;

                 // LINQ Extension Methods
            var cheapBooks = books
                .Where(b => b.Price <= 10)
                .OrderBy(b => b.Title)
                .Select(b => b);
            foreach(var book in cheapBooks)
                Console.WriteLine(book.Title + " " + book.Price);

            // Other useful methods: We can use them to Query Objects, Databases, XML and ADO.NET Data sets

            /*books.Where();
            books.Single();
            books.SingleOrDefault();

            books.First();
            books.FirstOrDefault();

            books.Last();
            books.LastOrDefault();

            books.Min();
            books.Max();
            books.Count();
            books.Sum();
            books.Average();

            books.Skip().Take(3);*/


            // 11. Linq
        }

    }
}
