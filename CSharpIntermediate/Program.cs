using System;

namespace CSharpIntermediate
{
    class Program
    {

        static void Main(string[] args)
        {
            var cookie = new HttpCookie {["name"] = "Awais"};
            Console.WriteLine(cookie["name"]);
            // 14 Indexers

        }
    }
}
