using System;
using System.Net.Security;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            var customer1 = new Customer(1);
            var customaer2 = new Customer(2, "Awais");

            var order =new Order();
            customaer2.Orders.Add(order);

            Console.WriteLine("ID: {0}  Name{1}",customaer2.Id,customaer2.Name);
            // 8 Constructors
        }
    }
}
