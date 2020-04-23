using System;

namespace CSharpIntermediate
{
    public class Upload : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Video is uploading...");
        }
    }
}