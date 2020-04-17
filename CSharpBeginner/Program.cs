using System;
using System.Collections.Generic;
using System.Text;


namespace CSharpBeginner
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var builder  = new StringBuilder();

            builder
                .Append('+', 10)
                .AppendLine()
                .Append("Awais Saeed")
                .AppendLine()
                .Append('+', 10)
                .Replace('+', '-')
                .Remove(0,10)
                .Insert(0, new string("Name: "));
            Console.WriteLine(builder);
            Console.WriteLine("First Char: "+builder[0]);
            // 66 and 67. StringBuilder
        }



    }
} 
