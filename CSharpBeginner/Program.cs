using System;
using System.Security.Cryptography;

namespace CSharpBeginner
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Awais Saeed";

            Console.WriteLine("Using Foor Loop");
            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine("Using Foreach LOOP");

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }


            // 45 and 46 For Loop and foreach Loop


        }

    }
} 
