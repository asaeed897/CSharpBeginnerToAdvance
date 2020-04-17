using System;


namespace CSharpBeginner
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Awais Saeed ";
            fullName = fullName.Trim();
            Console.WriteLine("Trim: '{0}'",fullName);

            var index = fullName.IndexOf(" ");
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("FirstName: "+firstName);
            Console.WriteLine("LastName: "+lastName);

            Console.WriteLine("ToUpper: "+ fullName.ToUpper());

            var name = fullName.Split(' ');
            Console.WriteLine("FirstName: " + name[0]);
            Console.WriteLine("LastName: " + name[1]);

            var str = "534";
            var num = int.Parse(str);
            var num1 = Convert.ToInt32(str);

            Console.WriteLine("Parse: {0}\nConvertToInt32: {1}",num,num1);
            // 62, 63 and 64. Introduction and Strings
        }


    }
} 
