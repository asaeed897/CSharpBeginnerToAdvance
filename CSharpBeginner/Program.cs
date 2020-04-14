

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
            
            var cal = new Calculator();
            cal.num1 = 4;
            cal.num2 = 5;
            int sum = cal.add();
            Console.WriteLine("Sum: " +sum);
            // 29 Structs 
        }
    }
}
