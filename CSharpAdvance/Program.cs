using System;

namespace CSharpAdvance
{
    class Program
    {
        // args => expressions

        //() => ... used when u have no arguments
        //x => ... when u have single arg
        //(x, ,y z) => ... used when u have multiple arguments

        static void Main(string[] args)
        {
            const int factor = 5;
            Func<int, int> multiplier = n => n* factor;
            var result = multiplier(10);

            Console.WriteLine(result);

            var books = new BookRepository().GetBooks();

            var cheapbooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapbooks)
            {
                Console.WriteLine(book.Title);
            }
            // 8. Lambda Expression
        }

        
    }
}
