using System;
using System.Security.Cryptography;

namespace CSharpBeginner
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or OK to exit): ");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                {
                    break;
                }

                sum += Convert.ToInt32(input);
            }

            Console.WriteLine("Sum: "+sum);

            //Exercise 2
            Console.Write("Write comma Separated numbers: ");
            var numberString = Console.ReadLine();

            var numbers = numberString.Split(',');
            var max = Convert.ToInt32(numbers[0]);

            foreach (var number in numbers)
            {
                var num = Convert.ToInt32(number);
                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine("Max: "+max);
            // 49 and 50 Exercise & Summary


        }

    }
} 
