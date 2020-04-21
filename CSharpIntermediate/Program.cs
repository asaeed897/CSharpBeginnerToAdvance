using System;
using System.Collections;

namespace CSharpIntermediate
{
    class Program
    {

        static void Main(string[] args)
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Count: {0}",stack.Size());
            Console.WriteLine(stack.Pop());
            Console.WriteLine("Count: {0}",stack.Size());
            Console.WriteLine(stack.Pop());
            Console.WriteLine("Count: {0}",stack.Size());
            Console.WriteLine(stack.Pop());
            Console.WriteLine("Count: {0}",stack.Size());

            // 26 and 27 Summary and Exercise
        }
    }
}
