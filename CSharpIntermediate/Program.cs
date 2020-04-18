using System;

namespace CSharpIntermediate
{
    public class Person
    {
        public string Name;

        public void Introduce(string toName)
        {
            Console.WriteLine("Hi {0}, I am {1}",toName,Name);
        }

        public static Person Parse(string str)
        {
            return new Person() {Name = str};
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person();
           // person.Name = "Awais";
            //person.Introduce("Asim");

            var person = Person.Parse("Awais");
            person.Introduce("Asim");
            // 7 Introduction to Classes
        }
    }
}
