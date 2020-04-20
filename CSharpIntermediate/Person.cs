using System;

namespace CSharpIntermediate
{
    public class Person
    {
        public string Name { get; set; }
        public string Username { get; set; } //Auto Implemented Properties
        public DateTime Birthdate { get; private set; } // Here I set "SET" method as private so no one can change after creating object

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public int Age // Simple Properties
        {
            get
            {
                var timeSapn = DateTime.Today - Birthdate;
                var years = timeSapn.Days / 365;

                return years;
            }
        }
    }
}