using System;
using System.Collections.Generic;


namespace CSharpBeginner
{

    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2 };
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in numbers)
                Console.WriteLine(number);
            // 82 and 83 Call stack, Locals and Autos Windows
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            if (list == null)
            {
                throw new ArgumentNullException("list");
            }
            if (list.Count < count || count <= 0)
            {
                throw new ArgumentOutOfRangeException("Count", "Count should be between 1 and the number of elements in the list.");
            }
            var smallests = new List<int>();
            var buffer = new List<int>(list);
            while (smallests.Count < count)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                    min = list[i];
            }
            return min;
        }
    }
} 
