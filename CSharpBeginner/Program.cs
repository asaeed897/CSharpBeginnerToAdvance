

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
            
            var numbers = new int[3] {1,2,3};

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var names = new string[3] {"Awais", "Mustansar", "Asim"};
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            // 30 and 31 Arrays 
        }
    }
}
