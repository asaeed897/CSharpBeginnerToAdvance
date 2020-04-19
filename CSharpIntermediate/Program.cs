using System;
using System.Net.Security;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            /*try
            {
                var num = int.Parse("abc");
            }
            catch (Exception e)
            {
                Console.WriteLine("Conversion failed");
            }*/

            // Alternate method by using out Modifier
            var result = int.TryParse("abc", out number);
            if (result)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }
            // 10 Methods
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 4, 5));
            Console.WriteLine(calculator.Add(1, 2, 4, 5, 5, 6));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));

        }
        static void UsePoints()
        {
            try
            {
                var point = new Point(2, 3);
                point.Move(10, 20);
                Console.WriteLine("(X,Y): ({0},{1})", point.X, point.Y);

                point.Move(new Point(5, 10));
                Console.WriteLine("(X,Y): ({0},{1})", point.X, point.Y);
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occured");
            }

        }
    }
}
