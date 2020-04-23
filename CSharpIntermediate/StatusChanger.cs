using System;

namespace CSharpIntermediate
{
    public class StatusChanger : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Video is in processing state");
        }
    }
}