using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class VideoEncoder : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Video is ready for encoding...");
        }
    }
}