using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = 5;
                //var result = number / 0;
                throw new Exception("Oops.");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new MyException("Do not divide any number with zero.", e);
            }
            finally
            {
                // if we have some StreamReader variables or open file handler which CLR didn't dispose
                // we dispose them here manually
                // but USING a 'using block' is better choice. it dispose those variable automatically
            }
            // 14. Exception Handling
        }

    }
}   
