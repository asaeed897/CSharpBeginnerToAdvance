using System;

namespace CSharpIntermediate
{
    public class StatusChanger : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Video is in processing state");
        }
    }
}