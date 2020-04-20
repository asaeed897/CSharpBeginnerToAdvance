using System;

namespace CSharpIntermediate
{
    public class Stopwatch
    {
        private static DateTime _start; 
        private static DateTime _end;
        public static int Count = 0;

        public static TimeSpan Duration
        {
            get => _end - _start;
        }

        public static void Start()
        {
            if (Count < 1)
            {
                _start = DateTime.Now;
                Count++;
            }
            else
            {
                throw new InvalidOperationException("Can't use this method twice without calling End method");
            }
        }

        public static void End()
        { 
            _end = DateTime.Now;
            Count = 0;
        }
    }
}