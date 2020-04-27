using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "Mosh";

            //Reflection is just like below and when we don't have dynamic we use this
            //var methodInfo = obj.GetType().GetMethod("GetHashCode");
           // methodInfo.Invoke(null,null);

            dynamic name = obj;
            name = 10;

            Console.WriteLine(name);

            // 13. Dynamic
        }

    }
}
