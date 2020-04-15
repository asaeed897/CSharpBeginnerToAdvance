using System;
using System.Security.Cryptography;

namespace CSharpBeginner
{
    public enum Season
    {
        Spring,
        Summer,
        Winter,
        Autumn
    }
    class Program
    {
        static void Main(string[] args)
        {

            var num = 10;
            if (num > 10)
            {
                Console.WriteLine("Given number is greater than 10");
            }
            else if (num == 10)
            {
                Console.WriteLine("Given number is equal to 10");
            }
            else
            {
                Console.WriteLine("Given number is less than 10");
            }

            switch (Season.Spring)
            {
                case Season.Autumn:
                    Console.WriteLine("It's a beautiful season.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's known for vacations");
                    break;

                default:
                    Console.WriteLine("Stay Home, Stay Safe. It's Corona Season!!!");
                    break;
            }
            // 41, 42 and 43 If/Else and Switch statements


        }

    }
} 
