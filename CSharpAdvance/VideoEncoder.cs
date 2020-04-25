using System;
using System.Threading;

namespace CSharpAdvance
{
    public class VideoEncoder
    {
        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise the event
        //public delegate void VideoEncodedEventHandler(Object source, VideoEventArgs args);

        // EventHandler      built .NET core delegates
        // EventHandler<TEventArgs>

        //public event VideoEncodedEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded; 
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video) // Event Publisher method and its name is based on .net core convention
        {
            if(VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs(){Video = video});
        }
    }
}