

using System;

namespace CSharpBeginner
{
    public struct Calculator
    {
        public int num1;
        public int num2;

        public int add()
        {
            return num1 + num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Awais";
            var lastName = "Saeed";
            var fullName = firstName + " " + lastName; ;
            Console.WriteLine(fullName);

            var myFullName = string.Format("My name is {0} {1}",firstName,lastName);
            Console.WriteLine(myFullName);

            var names = new string[3] {"Asim", "Awais", "Mustensar"};
            var formattedNames = string.Join(",", names);
            Console.WriteLine(formattedNames);

            var line = @"Hello,
 My name is Awais";
            Console.WriteLine(line);

            // 32 and 33 Strings 
        }
    }
}
