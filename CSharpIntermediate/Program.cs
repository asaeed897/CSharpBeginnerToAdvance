

using System;
using System.Collections;

namespace CSharpIntermediate
{
    class Program
    {

        static void Main(string[] args)
        {
            var number = 10;
            var obj = (Object) number; // boxing: converting value type to reference type
            var num = (int) obj; // unboxing: converting reference type to value type

            Console.WriteLine(num);

            var list = new ArrayList(); 
            list.Add(1); //here when we add something to it that will cast to a reference type
            list.Add("Mosh");
            list.Add(DateTime.Today);


            // 25 Boxing and Unboxing
        }
    }
}
