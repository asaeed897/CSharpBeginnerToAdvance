using System;
using System.Net.Security;

namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer() {Name = "Awais", Id = 1};
            

            var order =new Order();
            customer.Orders.Add(order);

            Console.WriteLine("ID: {0}  Name{1}",customer.Id,customer.Name);
            // 9 Object Initializer
        }
    }
}
