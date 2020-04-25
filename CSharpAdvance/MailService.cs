using System;

namespace CSharpAdvance
{
    public class MailService
    {
        public void OnVideoEncoded(Object source, VideoEventArgs e) //Event handler method
        {
            Console.WriteLine("MailService: Sending an email..."+ e.Video.Title);
        }
    }
}