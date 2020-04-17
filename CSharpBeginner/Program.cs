using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace CSharpBeginner
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\awais\Downloads\Video\image.jpg";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: "+Path.GetExtension(path));
            Console.WriteLine("File Name: "+Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: "+Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: "+Path.GetDirectoryName(path));

            // 75, 76, and 77. Path class & Summary
        }

    }
} 
