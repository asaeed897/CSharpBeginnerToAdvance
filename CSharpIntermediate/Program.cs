using System.Data;
using Amazon;

namespace CSharpIntermediate
{
    /*public class GoldCustomer : Customer // This class I use to check Protected Access Modifier
    {
        public void OfferVouchar()
        {
            var rating = this.CalculatingRating(true);
        }
    }*/

    class Program
    {

        static void Main(string[] args)
        {
            var customer = new Customer();
            //Amazon.RateCalculator calculator = new RateCalculator(); // Now I change this class in Amazon Assembly then this file get
                                                                     // effected too. So In other assemblies where we want to encapsulate 
                                                                     // one class from the classes on other libraries we use Internal Modifier


            // 22 Access Modifiers Public Private Protected internal and Protected internal
        }
    }
}
