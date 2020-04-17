using System;
using System.Collections.Generic;


namespace CSharpBeginner
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "My name is Muhammad Awais Saeed and today I am feeling bore";

            var summary = StringUtility.SummarizeText(sentence);
            Console.WriteLine(summary);
            // 65. Live Coding Summarizing Text
        }



    }
} 
