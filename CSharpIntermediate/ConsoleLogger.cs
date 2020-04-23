using System;

namespace CSharpIntermediate
{
    public class ConsoleLogger : ILogger // Here This class can implement multiple interfaces but can't inherited from multiple classes
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
}