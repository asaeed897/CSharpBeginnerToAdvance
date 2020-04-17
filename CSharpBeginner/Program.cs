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
            var path = @"c:\myfolder\document.txt";
            var path1 = @"d:\myfolder\document.txt";
            //File Class
            File.Copy(path,path1,true);
            File.Delete(path);
            if (File.Exists(path))
            {
                var content = File.ReadAllLines(path);
            }

            //FileInfo Class
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(path1);
            if (fileInfo.Exists)
            {
                var streamReader = fileInfo.OpenText();
                var firstLine = streamReader.ReadLine();
            }
            fileInfo.Delete();

            // 71, 72 and 73. Introduction and File and FileInfo
        }

    }
} 
