using System;

namespace CSharpBeginner
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Indtroduction()
        {
            Console.WriteLine("My name is " + firstName + " "+ lastName);
        }
    }
}