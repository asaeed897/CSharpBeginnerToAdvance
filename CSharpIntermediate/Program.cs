using System;
using System.Net.Security;

namespace CSharpIntermediate
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
           var person = new Person();
           person.SetBirthdate(new DateTime(1997,01,22));
           Console.WriteLine(person.GetBirthdate());

            // 12 Access Modifiers
        }

        
    }
}
