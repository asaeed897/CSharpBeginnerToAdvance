

using System;
using CSharpBeginner.Math;

namespace CSharpBeginner
{
    class Program
    {
        static void Main(string[] args)
        {
            var awais = new Person();
            awais.firstName = "Awais";
            awais.lastName = "Saeed";
            awais.Indtroduction();
            var cal = new Calculator();
            cal.num1 = 4;
            cal.num2 = 5;
            int sum = cal.add();
            Console.WriteLine("Sum: " +sum);
            // 26, 27 and 28 Classes 
        }
    }
}
