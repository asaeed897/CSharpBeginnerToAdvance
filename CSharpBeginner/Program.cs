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
            var path = @"C:\Users\awais\Downloads\Video";

            Directory.CreateDirectory(@"c:\folder");
            var files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            /*foreach (var file in files)
            {
                Console.WriteLine(file);
            }*/

            var directories = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists(path);

            var directoryInfo = new DirectoryInfo(path);
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();


            // 74. Directory and DirectoryInfo
        }

    }
} 
