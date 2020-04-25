using System;

namespace CSharpAdvance
{
    public class MessageService
    {
        public void OnVideoEncoded(Object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message..."+ args.Video.Title);
        }
    }
}