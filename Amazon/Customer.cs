using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);
            Console.WriteLine("Promote logic");
        }

        /*protected int CalculatingRating(bool excludeOrders) I created this method to check protected Modifier
        {
            return 0;
        }*/
    }
}