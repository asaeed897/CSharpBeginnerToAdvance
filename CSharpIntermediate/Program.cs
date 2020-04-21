

using System;

namespace CSharpIntermediate
{
    class Program
    {

        static void Main(string[] args)
        {
            /*var text = new Text(); //   UpCasting 
            Shape shape = text;

            text.Width = 100;
            shape.Width = 200;

            Console.WriteLine(text.Width);*/

            var shape = new Shape();
            var text = (Text) shape; // DownCasting but it is not safe because it can throw an exception 
            var text1 = shape as Text; // This is the safe method because if it can't type cast then it return null
            if (text1 != null)
            {
                //something
            }
            {
                
            }
            // Note: "IS" is keyword which we can use to check the type of object
            if (text1 is Text)
            {
                Console.WriteLine("Object has type Text");
            }


            // 24 UpCasting and DownCasting
        }
    }
}
