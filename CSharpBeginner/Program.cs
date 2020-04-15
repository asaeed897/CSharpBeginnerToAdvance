using System;
using System.Security.Cryptography;

namespace CSharpBeginner
{
    public enum ImageOrientation
    {
        Landscape,
        Portrait
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Image Width: ");
            var width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Image Height");

            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is "+ orientation);
            // 43 If/Else and Switch statements Exercise


        }

    }
} 
