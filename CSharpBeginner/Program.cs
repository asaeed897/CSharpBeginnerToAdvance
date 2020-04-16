using System;


namespace CSharpBeginner
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var Date = new DateTime(2020,01,22);
            Console.WriteLine(Date);

            var now = DateTime.Now;
            /*Console.WriteLine(now.Day);
            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);*/

            now = now.AddDays(1);
            Console.WriteLine(now.Day);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("dd-MM-yyyy"));

            // 59 DateTime

        }


    }
} 
