using System;

namespace CSharpIntermediate
{
    public class Upload : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Video is uploading...");
        }
    }
}