using System;

namespace CSharpBeginner
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5;
            int i = b;   //implict conversion
            Console.WriteLine("b: {0} i: {1}",b, i);

            int c = 1000;
            byte j = (byte)c; //explicit conversion
            Console.WriteLine("c: {0} j: {1}", c, j);

            var number = "1234";
            int k = Convert.ToInt32(number); //non-compatible types conversion
            Console.WriteLine("number: {0} k: {1}",number,k);
            //19 and 20. Type Conversion
        }
    }
}
