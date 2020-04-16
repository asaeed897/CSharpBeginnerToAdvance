using System;
using System.Security.Cryptography;

namespace CSharpBeginner
{
    
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Type your name: ");
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo "+ input);
                    continue;
                }

                break;
            }


            // 47 While Loop 


        }

    }
} 
