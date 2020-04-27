using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null; // We convert value types to nullable type where we need them

            DateTime date2 = date ?? DateTime.Today;

            DateTime date3 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

            Console.WriteLine(date2);

            // 12. Nullable Types
        }

    }
}
