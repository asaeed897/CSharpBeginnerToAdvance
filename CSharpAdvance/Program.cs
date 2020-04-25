namespace CSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video(){Title = "video 1"};
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService(); //subscriber


            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
            // 9. Events and Delegates
        }

       
    }
}
