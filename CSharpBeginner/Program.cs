using System;
using System.Security.Cryptography;

namespace CSharpBeginner
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = a;
            b++;
            Console.WriteLine("a: {0}, b: {1}", a,b);

            var arry1 = new int[3] {1, 2, 3};
            var arry2 = arry1;
            arry2[0] = 0;
            Console.WriteLine("arry1: {0}, arry2: {1}", arry1[0],arry2[0]);

            // 36, 37 and 38 Reference Types and Value Types

            var number = 5;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() {Age = 20};
            MakeOld(person);
            Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number++;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
} 
