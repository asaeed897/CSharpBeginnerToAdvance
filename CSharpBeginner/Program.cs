using System;

namespace CSharpBeginner
{
    class Program
    {
        static void Main(string[] args)
        {
            byte num = 255;
            Console.WriteLine("Before " + num);
            num = (byte)(num + 1);
            Console.WriteLine("After " + num);
            //Overflow
        }
    }
}
