using System;


namespace CSharpBeginner
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Creating
            var timeSpan = new TimeSpan(1,2,3);
            var timeSpan1 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = start.AddMinutes(2);
            var duration = end - start; // Here duration id become a timeSpan object
            Console.WriteLine("Duration: "+ duration);

            //Properties
            Console.WriteLine("Minutes: "+ timeSpan.Minutes);
            Console.WriteLine("TotalMinutes: "+ timeSpan.TotalMinutes);

            //Add
            Console.WriteLine("Add Example: "+ timeSpan.Add(TimeSpan.FromMinutes(8)));

            //Subtract 
            Console.WriteLine("Subtract: "+ timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString: "+ timeSpan.ToString());

            //Parse
            Console.WriteLine("Parse: "+ TimeSpan.Parse("01:05:20"));

            // 60. TimeSpan
        }


    }
} 
