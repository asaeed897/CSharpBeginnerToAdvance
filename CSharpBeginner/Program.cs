using System;
using System.Collections.Generic;
using System.Text;


namespace CSharpBeginner
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            var input = Console.ReadLine();

            Console.WriteLine("Total Vowels in {0}: {1}",input, CountVowels(input));
            // 68 and 69. Procedural Programming Exercise & Summary
        }

        static int CountVowels(String input)
        {
            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            var vowelsCount = 0;
            foreach (var character in input.ToLower())
            {
                if (vowels.Contains(character))
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }



    }
} 
