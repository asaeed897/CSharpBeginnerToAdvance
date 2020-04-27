using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be very long post blah blah blah...";
            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);

            // Most of the time we use Extension method instead of creating them
            // For Example
            
            IEnumerable<int> numbers = new List<int>() {1, 4, 88, 12, 30};
            var max = numbers.Max();

            Console.WriteLine(max);
            // 10. Extension Methods
        }

    }
}
