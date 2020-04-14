using System;

namespace CSharpBeginner
{
    public enum ShippingMethods
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethods.Express;
            Console.WriteLine((int)method);

            var methodId = 2;
            Console.WriteLine((ShippingMethods) methodId) ;

            var methodString = method.ToString();
            Console.WriteLine(methodString);

            var methodName = "Express";
            var shippingMethods = (ShippingMethods)Enum.Parse(typeof(ShippingMethods), methodName);
            Console.WriteLine(shippingMethods); 
            // 34 and 35 Enums
        }

    }
} 
