using System;
using System.Security.Cryptography;

namespace CSharpBeginner
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {1, 2, 7, 8, 3, 4, 5};
            //Length
            Console.WriteLine("Length of array: "+ numbers.Length);

            //IndexOf
            Console.WriteLine("Index of 7: "+Array.IndexOf(numbers, 7));

            //Clear()
            Array.Clear(numbers,2, 2);
            Console.WriteLine("Effects of Clear");
            foreach (var VARIABLE in numbers)
            {
                Console.WriteLine(VARIABLE);
            }

            //Copy()
            var another = new int[4];
            Array.Copy(numbers, another, 4);
            Console.WriteLine("Another Array: ");
            foreach (var VARIABLE in another)
            {
                Console.WriteLine(VARIABLE);
            }
            
            //Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effects of Sort");
            foreach (var VARIABLE in numbers)
            {
                Console.WriteLine(VARIABLE);
            }

            //Reverse()
             Array.Reverse(numbers);
             Console.WriteLine("Effects of Reverse");
             foreach (var VARIABLE in numbers)
             {
                 Console.WriteLine(VARIABLE);
             }
            // 51, 52 and 53 Introduction and Arrays

        }

    }
} 
