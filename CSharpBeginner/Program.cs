using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpBeginner
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write your name: ");
            var name = Console.ReadLine();

            var nameArray = new char[name.Length];
            // Alternate method
            /*for (int i = 0; i < name.Length; i++)
            {
                nameArray[i] = name[i];
            }

            Array.Reverse(nameArray);*/
            
            var j = 0;
            for (int i = name.Length -1 ; i >=0; i--)
            {
                nameArray[j] = name[i];
                j++;
            }

            foreach (var Character in nameArray)
            {
                Console.Write(Character);
            }
            // 56 and  57 Exercise and Summary

        }


    }
} 
