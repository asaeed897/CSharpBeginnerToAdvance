using System;

namespace CSharpIntermediate
{
    class Program
    {
        
        static void Main(string[] args)
        {
           var person = new Person(new DateTime(1997, 01, 22));
           person.Name = "Awais";
           Console.WriteLine(person.Age);

            // 13 Properties
        }

        
    }
}
