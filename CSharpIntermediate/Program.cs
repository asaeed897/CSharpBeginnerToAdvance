using System;
using System.Net.Security;

namespace CSharpIntermediate
{
    class Program
    {
        
        static void Main(string[] args)
        {
           var customer = new Customer(1);
           
           customer.Orders.Add(new Order());
           customer.Orders.Add(new Order());

           Console.WriteLine(customer.Orders.Count);

            // 11 Fields
        }

        
    }
}
